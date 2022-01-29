import { Socio } from "./Socio";

export class Mensalidades{
    Id: number;
    dataVencimento: Date;
    valorInicial: number;
    dataPagamento: Date;
    juros: number;
    valorFinal: number;
    quitada: boolean;
    Socio: Socio;
}
