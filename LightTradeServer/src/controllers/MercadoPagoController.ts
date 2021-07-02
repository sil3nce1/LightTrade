import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { addDays, calculatePercentage, generateValidModelId, getDaysDifference } from "../helpers";
import { Coupon } from "../models/Coupon";
import { Plan } from "../models/Plan";
import mercadopago, { payment } from "mercadopago";
import { Payment } from "../models/Payment";
import { PlanAccount } from "../models/PlanAccount";
import { PaymentStatusEnum } from "../enums/PaymentStatusEnum";
import { Account } from "../models/Account";


const mpAccessToken = process.env.MERCADOPAGO_ACCESS_TOKEN;
const appName = process.env.APP_NAME;
const mpNotificationUrl = process.env.MERCADOPAGO_NOTIFICATION_URL;

mercadopago.configure({
    access_token: mpAccessToken
});

interface MercadoPagoPaymentId {
    id: number;
}

interface MercadoPagoPaymentResponse {
    id: string;
    live_mode: boolean;
    type: string;
    date_created: Date;
    application_id: string;
    user_id: string;
    version: string;
    api_version: string;
    action: string;
    data: MercadoPagoPaymentId;
}

class MercadoPagoController {
    public async index(req: Request, res: Response): Promise<Response> {
        const { planId, couponCode } = req.params;
        const planRepository = getRepository(Plan);
        const couponRepository = getRepository(Coupon);
        const paymentRepository = getRepository(Payment);

        const plan = await planRepository.findOne(planId);
        
        if (!plan)
            return res.status(400).json({success: false, message: "Invalid plan"});

        let price = 9999;
        let coupon = null;
        if (couponCode) {
            coupon = await couponRepository.findOne({code: couponCode});
            if ((!coupon) || (!coupon.isValid())) {
                price = plan.price;
            } else {
                price = plan.price - calculatePercentage(coupon.percentage, plan.price);
            }

        } else {
            price = plan.price;
        }
        const paymentId = await generateValidModelId(Payment);
        const payment = paymentRepository.create({
            id: paymentId,
            coupon,
            plan,
            platform: "MercadoPago",
            price,
            account: req.account,
        });
        await paymentRepository.save(payment);

        const response = await mercadopago.preferences.create({
            items: [
                {
                    currency_id: 'BRL',
                    unit_price: price,
                    quantity: 1,
                    title: `${appName} - ${plan.name}`
                }
            ],
            notification_url: `${mpNotificationUrl}/${paymentId}`
        });

        

        return res.status(200).json({success: true, url: response.body.init_point});
    }

    public async paymentCb(req: Request, res: Response): Promise<Response> {
        const { paymentId } = req.params;
        const mpPaymentResponse = req.body as MercadoPagoPaymentResponse;
        const couponRepository = getRepository(Coupon);
        const planRepository = getRepository(Plan);
        const planAccountRepository = getRepository(PlanAccount);
        const paymentRepository = getRepository(Payment);
        const accountRepository = getRepository(Account);

        try {
            const paymentInfo = await mercadopago.payment.get(mpPaymentResponse.data.id);
            console.log("heree mp")
            if (paymentInfo.body.status == "approved") {
                console.log("approved");
                const payment = await paymentRepository.findOne(paymentId);
                if ((payment) && (payment.status == PaymentStatusEnum.PAID)) {
                    console.log("masmeme");
                    return res.status(200).send();
                }
                    
                if (payment.coupon) {
                    const coupon = await couponRepository.findOne({code: payment.coupon.code});
                    coupon.uses++;
                    await couponRepository.save(coupon);
                }
                let planAccount = null;
                console.log(paymentId);
                console.log(payment.account);
                const account = await accountRepository.findOne(payment.account.id);
                const plan = await planRepository.findOne(payment.plan.id);

                if (account.hasPlan()) {
                    planAccount = await planAccountRepository.findOne({account: payment.account});
                    const daysDiff = getDaysDifference(new Date(planAccount.endDate), new Date());
                    planAccount.plan = plan;
                    planAccount.startDate = new Date();
                    planAccount.account = account;
                    planAccount.endDate = addDays(new Date(), daysDiff + plan.days);
                } else {
                    planAccount = await planAccountRepository.findOne({account: payment.account});
                    if (planAccount) {
                        planAccount.plan = plan;
                        planAccount.endDate = new Date();
                        planAccount.startDate = new Date();
                        planAccount.account = account;
                        planAccount.endDate = addDays(new Date(), plan.days);
                    } else {
                        planAccount = planAccountRepository.create({
                            account,
                            startDate: new Date(),
                            plan,
                            endDate: addDays(new Date(), plan.days),
                        });
                    }
                }

                payment.status = PaymentStatusEnum.PAID;
                await paymentRepository.save(payment);
                await planAccountRepository.save(planAccount);
            }
            
        } 
        catch {
            return res.status(200).send();
        }

        return res.status(200).send();

    }
}

export default new MercadoPagoController();