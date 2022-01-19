namespace ClubeApi.Domain
{
    public class Dependente : Pessoa
    {
        //Declaração de atributos
        public int NumeroCartao { get; set; }
        public string Parentesco { get; set; }
       
        public int idSocio { get; set; }
    }
}
