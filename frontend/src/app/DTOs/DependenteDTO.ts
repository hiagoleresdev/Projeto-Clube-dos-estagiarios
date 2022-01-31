import { PessoaDTO } from "./PessoaDTO";

export class DependenteDTO extends PessoaDTO {
    NumeroCartao: number;
    Parentesco: string;
    FkSocio: number;
}