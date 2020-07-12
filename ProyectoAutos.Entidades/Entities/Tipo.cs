using System;

namespace ProyectoAutos.Entidades.Entities
{
    public class Tipo:ICloneable
    {
        public int TipoId { get; set; }

        public string Descripcion { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
