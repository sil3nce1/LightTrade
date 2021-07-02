import { Router } from "express";
import CouponController from "../controllers/CouponController";
import { accountMiddleware } from "../middlewares/accountMiddleware";


const routes = Router();

routes.get("/:code", [accountMiddleware], CouponController.index);


export default routes;