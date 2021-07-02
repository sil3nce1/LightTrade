import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { Coupon } from "../models/Coupon";




class CouponController {
    public async index(req: Request, res: Response): Promise<Response> {
        const { code } = req.params;
        const couponRepository = getRepository(Coupon);

        const coupon = await couponRepository.findOne({code});

        if (coupon) {
            if (!coupon.isValid())
            return res.status(200).json();
        }
        

        return res.status(200).json(coupon);
    }

}

export default new CouponController();