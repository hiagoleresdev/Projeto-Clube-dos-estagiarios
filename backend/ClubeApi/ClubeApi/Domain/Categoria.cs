namespace ClubeApi.Domain
{
    public class Categoria
    {
        //Declaração de atributos
        public int Id { get; set; }
        public string Tipo { get; set; }
        public List<Socio> Socios { get; set; }
    }
}