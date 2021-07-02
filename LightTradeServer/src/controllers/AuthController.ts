import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { Account } from "../models/Account";
import * as EmailValidator from "email-validator";
import * as bcryptjs from "bcryptjs";
import * as jwt from "jsonwebtoken";

const freePlan = process.env.FREE_PLAN == 'true' ? true : false;

class AuthController {
    public async signIn(req: Request, res: Response): Promise<Response> {
        const { username, password } = req.body;
        console.log(username, password);
        const accountRepository = getRepository(Account);
        let account = null;
        if (EmailValidator.validate(username)) {
            account = await accountRepository.findOne({email: username});
            if (!account)
                return res.status(400).json({success: false, message: "Incorrect username or password"});
            
            if (!bcryptjs.compareSync(password, account.password))
                return res.status(400).json({success: false, message: "Incorrect username or password"});
        } else {
            account = await accountRepository.findOne({username});
            if (!account)
                return res.status(400).json({success: false, message: "Incorrect username or password"});
            
            if (!bcryptjs.compareSync(password, account.password))
                return res.status(400).json({success: false, message: "Incorrect username or password"});
        }

        console.log(account.password);
        const token = jwt.sign({email: account.email, password: account.password, ipAddress: req.ip}, process.env.JWT_SECRET_KEY);
        await accountRepository.save(account);
        delete account.password;
        return res.status(200).json({success: true, token, account: {...account, hasPlan: account.hasPlan(), planAccount: { ...account.planAccount, planRemainingTime: account.getPlanRemainingTime()}, freePlan}});
    }
}

export default new AuthController();