import { NextFunction, Request, Response } from "express";



export const isEmailConfirmedMiddleware = async function(req: Request, res: Response, next: NextFunction) {
    if (req.account.isEmailConfirmed)
        return next();
    else
        return res.status(400).json({success: false, message: "Your email isn't confirmed yet"});
}