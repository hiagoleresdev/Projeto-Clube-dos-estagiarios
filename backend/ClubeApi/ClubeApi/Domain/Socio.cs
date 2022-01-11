namespace ClubeApi.Domain
{
    public class Socio : Pessoa
    {
        //Declaração de atributos
        private int NumeroCartao { get; set; }
        private String telefone { get; set; }
        private String Cep { get; set; }
        private String Uf { get; set; }
        private String Cidade { get; set; }
        private String Bairro { get; set; }
        private String Logradouro { get; set; }
        private Categoria Categoria { get; set; }
        private List<Mensalidade> Mensalidades { get; set; }
        private List<Dependente> Dependentes { get; set; }
    }
}
