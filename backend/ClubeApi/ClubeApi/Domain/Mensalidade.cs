namespace ClubeApi.Domain
{
    public class Mensalidade
    {
        //Declaração dos atributos
        private int Id { get; set; }
        private DateTime DataVencimento { get; set; }
        private double ValorInicial { get; set; }
        private DateTime DataPagamento { get; set; }
        private int Juros { get; set; }
        private double ValorFinal { get; set; }
        private int Quitada { get; set; }
        private Socio Socio { get; set; }
    }
}
