import { Pessoa } from "./Pessoa";
import { Socio } from "./Socio";

export class Dependente extends Pessoa{
    numeroCartao: number;
    Parentesco: string;
    Socio: Socio;
}