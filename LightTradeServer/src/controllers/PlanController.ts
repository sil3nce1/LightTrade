import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { Plan } from "../models/Plan";




class PlanController {
    public async index(req: Request, res: Response): Promise<Response> {
        const { page } = req.params;
        const limit = 3;
        const toSkip = Number.parseInt(page) * limit;
        const planRepository = getRepository(Plan);

        const plans = await planRepository.find({
            skip: toSkip,
            take: limit
        });
        return res.status(200).json(plans);
    }
}

export default new PlanController();