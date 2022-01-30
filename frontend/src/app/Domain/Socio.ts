import { Categoria } from "./Categoria";
import { Dependente } from "./Dependente";
import { Mensalidades } from "./Mensalidades";
import { Pessoa } from "./Pessoa";

export class Socio extends Pessoa{
    numeroCartao: number;
    Telefone: string;
    Cep: string;
    Uf: string;
    Cidade: string;
    Bairro: string;
    Logradouro: string;
    Categoria: Categoria;
    Mensalidades: Mensalidades[];
    Dependentes: Dependente[];
}