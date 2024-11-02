import { ICV } from "./cv";

export interface ICVRetrieverResponse {
    message: string;
    cv?: ICV;
}