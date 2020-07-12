using ProyectoAutos.Entidades.DTOs.Marca;
using ProyectoAutos.Entidades.DTOs.Tipo;
using ProyectoAutos.Entidades.Entities;

namespace ProyectoAutos.Entidades.Mapas
{
    public class Mapeador
    {
        public static MarcaDto ConvertirAMarcaDto(Marca marcaDto)
        {
            return new MarcaDto
            {
                MarcaId = marcaDto.MarcaId,
                Nombre = marcaDto.Nombre
            };
        }
        public static Marca ConvertirAMarca(MarcaDto marca)
        {
            return new Marca
            {
                MarcaId = marca.MarcaId,
                Nombre = marca.Nombre
            };
        }
        public static TipoDto ConvertirATipoDto(Tipo tipo)
        {
            return new TipoDto
            {
                TipoId = tipo.TipoId,
                Descripcion = tipo.Descripcion
            };
        }
        public static Tipo ConvertirATipo(TipoDto tipoDto)
        {
            return new Tipo
            {
                TipoId = tipoDto.TipoId,
                Descripcion = tipoDto.Descripcion
            };
        }
    }
}
