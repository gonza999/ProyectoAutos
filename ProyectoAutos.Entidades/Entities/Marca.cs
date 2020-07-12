using System;

namespace ProyectoAutos.Entidades.Entities
{
    public class Marca : ICloneable
    {
        public int MarcaId { get; set; }
        public string Nombre { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
