require('dotenv').config();
import "reflect-metadata";
import { createConnection } from "typeorm";
createConnection();
import app from "./app";
import ws from "./ws";


const httpPort = Number.parseInt(process.env.HTTP_PORT);
const wsPort = Number.parseInt(process.env.WS_PORT);

app.listen(httpPort, () => console.log(`Server is running on port ${httpPort}`));
ws.listen(wsPort);


