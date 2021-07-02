import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { BrokerAccount } from "../models/BrokerAccount";




class BrokerAccountController {
    public async index(req: Request, res: Response): Promise<Response> {
        console.log("here");
        const { brokerId } = req.params;
        const brokerAccountRepository = getRepository(BrokerAccount);
        
        let brokerAccounts = null;
        if (brokerId.includes("-")) {
            brokerAccounts = await brokerAccountRepository.findOne({id: brokerId});
        }
        else {
            brokerAccounts = await brokerAccountRepository.find({brokerId: Number.parseInt(brokerId), account: req.account});
        }

        return res.status(200).json(brokerAccounts);
    }

    public async create(req: Request, res: Response): Promise<Response> {
        const { crypted, brokerId } = req.body;

        const brokerAccountRepository = getRepository(BrokerAccount);
        const tempBrokerAccounts = await brokerAccountRepository.find({brokerId, account: req.account});
        
        if (tempBrokerAccounts.length >= 4)
            return res.status(400).json({success: false, message: "Max accounts exceeded"});

        const brokerAccount = brokerAccountRepository.create({
            brokerId,
            crypted,
            account: req.account,
        });

        await brokerAccountRepository.save(brokerAccount);
        return res.status(201).json({success: true, message: "Broker account has been added"});
    }

    public async delete(req: Request, res: Response): Promise<Response> {
        const { brokerAccountId } = req.params;
        const brokerAccountRepository = getRepository(BrokerAccount);

        const brokerAccount = await brokerAccountRepository.findOne({id: brokerAccountId, account: req.account});
        await brokerAccountRepository.remove(brokerAccount);
        return res.status(200).json({success: true, message: "Broker account has been deleted"});
    }
}


export default new BrokerAccountController();