namespace ClubeApi.Domain
{
    public class Categoria
    {
        //Declara��o de atributos
        private int Id { get; set; }
        private string Tipo { get; set; }
        private List<Socio> Socios { get; set; }
    }
}