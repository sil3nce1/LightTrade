import { Request, Response, Router } from "express";
import axios from "axios";

const routes = Router();


routes.get("/glengine/:url", async function(req: Request, res: Response) {
    const { url } = req.params;
    const response = await axios.get(`https://static.cdnpub.info/traderoom/${url}`);
    let data = await response.data as string;
    data = data.replace("var socket;", "");
    data = data.replace("GLEngineModule:{};", "GLEngineModule:{};var socket=null;");
    data = data.replace("function(event){if(event.data instanceof", "function(event){onIqMessageReceived(event.data);if(event.data instanceof");
    data = data.replace("GLEngineModule.JSWebSockets[$0].send(UTF8ToString($1))", "{onIqMessageSent(UTF8ToString($1));GLEngineModule.JSWebSockets[$0].send(UTF8ToString($1));}");
    return res.header("Content-Type", "text/javascript").send(data);
});

export default routes;