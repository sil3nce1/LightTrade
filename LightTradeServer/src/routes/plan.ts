import { Router } from "express";
import PlanController from "../controllers/PlanController";
import { accountMiddleware } from "../middlewares/accountMiddleware";

const routes = Router();

routes.get("/:page", [accountMiddleware], PlanController.index);

export default routes;