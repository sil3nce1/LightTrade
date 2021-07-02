import { Router } from "express";
import MercadoPagoController from "../controllers/MercadoPagoController";
import { accountMiddleware } from "../middlewares/accountMiddleware";


const routes = Router();

routes.get("/:planId/:couponCode", [accountMiddleware], MercadoPagoController.index);
routes.get("/:planId/", [accountMiddleware], MercadoPagoController.index);
routes.post("/notification/:paymentId", MercadoPagoController.paymentCb);

export default routes;