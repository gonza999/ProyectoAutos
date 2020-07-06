namespace ProyectoAutos.Entidades.Entities
{
    public class Auto
    {
        public int AutoId { get; set; }
        public Marca Marca { get; set; }

        public string Modelo { get; set; }

        public Tipo Tipo { get; set; }

        public decimal Precio { get; set; }
    }
}
