import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { Account } from "../models/Account";



class AccountController {
    public async index(req: Request, res: Response): Promise<Response> {
        const account = req.account;
        delete account.password;
        return res.status(200).json(account);
    }

    public async create(req: Request, res: Response): Promise<Response> {
        const { username, email, password } = req.body;
        const accountRepository = getRepository(Account);
        try {
            let account = await accountRepository.findOne({username});
            if (account)
                return res.status(400).json({success: false, message: "Username already exists"});
            
            account = await accountRepository.findOne({email});
            if (account)
                return res.status(400).json({success: false, message: "Email already exists"});

            if (password.length < 6)
                return res.status(400).json({success: false, message: "Password must have 6 caracters at least"});
            else if (password.length > 15)
                return res.status(400).json({success: false, message: "Password cannot be greater than 15 caracters"});

            account = accountRepository.create({ username, email, password });
            await accountRepository.save(account);
            delete account.password;
            return res.status(200).json({success: true, message: "Account has been created", account});
        }
        catch {
            return res.status(400).json({success: false, message: "Failed to create account"});
        }
    }
}

export default new AccountController();