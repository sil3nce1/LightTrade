import { Router } from "express";
import accountRoutes from "./account";
import authRoutes from "./auth";
import brokerAccountRoutes from "./brokerAccount";
import planRoutes from "./plan";
import couponRoutes from "./coupon";
import mpRoutes from "./mercadopago";


const routes = Router();

routes.use("/accounts", accountRoutes);
routes.use("/auth", authRoutes);
routes.use("/brokerAccounts", brokerAccountRoutes);
routes.use("/plans", planRoutes);
routes.use("/coupons", couponRoutes);
routes.use("/mp", mpRoutes);

export default routes;