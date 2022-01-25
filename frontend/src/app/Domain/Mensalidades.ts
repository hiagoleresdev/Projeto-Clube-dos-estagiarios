import { SocketOptions } from "dgram";
import { Socio } from "./Socio";

export class Mensalidades{
    Id: number;
    dataVencimento: Date;
    valorInicial: number; 
    dataPagamento: Date;
    Juros: number;
    valorFinal: number;
    Quitada: boolean; 
    Socio: Socio;
}