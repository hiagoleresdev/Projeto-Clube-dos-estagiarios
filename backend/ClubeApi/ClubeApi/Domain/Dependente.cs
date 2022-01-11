namespace ClubeApi.Domain
{
    public class Dependente : Pessoa
    {
        //Declaração de atributos
        private int NumeroCartao { get; set; }
        private string Parentesco { get; set; }
        private Socio Socio { get; set; }
    }
}
