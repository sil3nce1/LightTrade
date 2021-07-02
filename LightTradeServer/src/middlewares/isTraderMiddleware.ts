import { NextFunction, Request, Response } from "express";



export const isTraderMiddleware = async function(req: Request, res: Response, next: NextFunction) {
    if (req.account.isTrader)
        return next();
    else
        return res.status(400).json({success: false, message: "You're not a trader"});
}