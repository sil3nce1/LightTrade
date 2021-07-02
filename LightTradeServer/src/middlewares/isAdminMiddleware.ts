import { NextFunction, Request, Response } from "express";



export const isAdminMiddleware = async function(req: Request, res: Response, next: NextFunction) {
    if (req.account.isAdmin)
        return next();
    else
        return res.status(400).json({success: false, message: "You're not an admin"});
}