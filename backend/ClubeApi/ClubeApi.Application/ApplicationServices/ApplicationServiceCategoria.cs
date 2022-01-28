using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.ApplicationServices;
using ClubeApi.Application.Interfaces.Mappers;
using ClubeApi.Domain.Core.Interfaces.Services;
using ClubeApi.Domain.Models;

namespace ClubeApi.Application.ApplicationServices
{
    public class ApplicationServiceCategoria : IApplicationServiceCategoria
    {
        //Atributos de referência às estrutura de serviço e mapeamento
        private readonly IServiceCategoria service;
        private readonly IMapperCategoria mapper;

        //Construtor
        public ApplicationServiceCategoria(IServiceCategoria service, IMapperCategoria mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public void Add(CategoriaDTO categoriaDTO)
        {
            Categoria categoria = mapper.MapperDTOToEntity(categoriaDTO);
            service.Add(categoria);
        }

        public void Delete(CategoriaDTO categoriaDTO)
        {
            Categoria categoria = mapper.MapperDTOToEntity(categoriaDTO);
            service.Delete(categoria);
        }

        public IEnumerable<CategoriaDTO> GetAll()
        {
            IEnumerable<Categoria> categorias = service.GetAll();
            return mapper.MapperListEntityToDTO(categorias);
        }

        public CategoriaDTO GetById(int id)
        {
            Categoria categoria = service.GetById(id);
            return mapper.MapperEntityToDTO(categoria);
        }

        public void Update(CategoriaDTO categoriaDTO)
        {
            Categoria categoria = mapper.MapperDTOToEntity(categoriaDTO);
            service.Update(categoria);
        }
    }
}
