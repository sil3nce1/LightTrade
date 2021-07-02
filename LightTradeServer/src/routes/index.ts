import { Router } from "express";
import apiRoutes from "./api";
import glEngineRoute from "./glengine"; 

const routes = Router();

routes.use("/api", apiRoutes);
routes.use('/iqoption', glEngineRoute);

export default routes;