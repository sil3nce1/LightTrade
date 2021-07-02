import { NextFunction, Request, Response } from "express";



export const hasPlanMiddleware = async function(req: Request, res: Response, next: NextFunction) {
    if (req.account.hasPlan())
        return next();
    else
        return res.status(400).json({success: false, message: "You don't have a plan"});
}