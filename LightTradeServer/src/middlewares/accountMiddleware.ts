import { NextFunction, Request, Response } from "express";
import * as jwt from "jsonwebtoken";
import { getRepository } from "typeorm";
import { Account } from "../models/Account";
import { TokenPayload } from "../interfaces/TokenPayload";

export const accountMiddleware = async function(req: Request, res: Response, next: NextFunction) {
    try {
        const token = req.header('Authorization').replace("Bearer","").trim();
        const tokenPayload = jwt.verify(token, process.env.JWT_SECRET_KEY) as TokenPayload;
        const accountRepository = getRepository(Account);
        const account = await accountRepository.findOne({email: tokenPayload.email, password: tokenPayload.password});

        if (!account)
            return res.status(400).json({success: false, message: "Invalid token"});
        if (tokenPayload.ipAddress != req.ip)
            return res.status(400).json({success: false, message: "Invalid token"});
        //if (account.authToken != token)
            //return res.status(400).json({success: false, message: "Invalid token"});

        req.account = account;
        console.log("ehehehe")
        return next();
    }
    catch {
        return res.status(400).json({success: false, message: "Invalid token"});
    }
}