import { PessoaDTO } from "./PessoaDTO";

    export class SocioDTO extends PessoaDTO{
        //Declaração de atributos
        NumeroCartao: number;
         Telefone: string;
         Cep: string;
         Uf: string;
         Cidade: string;
         Bairro: string;
         Logradouro: string;
        FkCategoria: number;
    }
