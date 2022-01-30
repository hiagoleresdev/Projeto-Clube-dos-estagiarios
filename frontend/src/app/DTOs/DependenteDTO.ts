import { PessoaDTO } from "./PessoaDTO";

export class DependenteDTO extends PessoaDTO {
    numeroCartao: number;
    parentesco: string;
    fk_Socio: number;
}
