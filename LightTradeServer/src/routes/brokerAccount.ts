import { Router } from "express";
import BrokerAccountController from "../controllers/BrokerAccountController";
import { accountMiddleware } from "../middlewares/accountMiddleware";
import { hasPlanMiddleware } from "../middlewares/hasPlanMiddleware";


const routes = Router();

routes.get("/:brokerId", [accountMiddleware], BrokerAccountController.index);
routes.post("/", accountMiddleware, BrokerAccountController.create);
routes.delete("/:brokerAccountId", accountMiddleware, BrokerAccountController.delete);

export default routes;