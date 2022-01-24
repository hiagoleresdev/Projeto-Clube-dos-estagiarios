using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.Mappers;
using ClubeApi.Domain.Models;

namespace ClubeApi.Application.Mappers
{
    public class MapperCategoria : IMapperCategoria
    {
        public Categoria MapperDTOToEntity(CategoriaDTO categoriaDTO)
        {
            Categoria categoria = new Categoria()
            {
                Id = categoriaDTO.Id,
                Tipo = categoriaDTO.Tipo,
                Meses = categoriaDTO.Meses
            };

            return categoria;
        }

        public CategoriaDTO MapperEntityToDTO(Categoria categoria)
        {
            CategoriaDTO categoriaDTO = new CategoriaDTO()
            {
                Id = categoria.Id,
                Tipo = categoria.Tipo,
                Meses = categoria.Meses
            };

            return categoriaDTO;
        }

        public IEnumerable<CategoriaDTO> MapperListEntityToDTO(IEnumerable<Categoria> categorias)
        {
            IEnumerable<CategoriaDTO> categoriasDTO = categorias.Select(c => new CategoriaDTO()
            {
                Id = c.Id,
                Tipo = c.Tipo,
                Meses = c.Meses
            });

            return categoriasDTO;
        }
    }
}
