import { Router } from "express";
import AccountController from "../controllers/AccountController";
import { accountMiddleware } from "../middlewares/accountMiddleware";


const routes = Router();

routes.get("/", accountMiddleware, AccountController.index);
routes.post("/", AccountController.create);


export default routes;