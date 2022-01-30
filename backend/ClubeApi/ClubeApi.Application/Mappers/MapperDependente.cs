﻿using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.Mappers;
using ClubeApi.Domain.Models;

namespace ClubeApi.Application.Mappers
{
    public class MapperDependente : IMapperDependente
    {
        public Dependente MapperDTOToEntity(DependenteDTO dependenteDTO, Socio socio)
        {
            Dependente dependente = new Dependente()
            {
                Id = dependenteDTO.Id,
                Nome = dependenteDTO.Nome,
                Email = dependenteDTO.Email,
                NumeroCartao = dependenteDTO.NumeroCartao,
                Parentesco = dependenteDTO.Parentesco,
                Socio = socio
            };

            return dependente;
        }

        public DependenteDTO MapperEntityToDTO(Dependente dependente)
        {
            DependenteDTO dependenteDTO = new DependenteDTO()
            {
                Id = dependente.Id,
                Nome = dependente.Nome,
                Email = dependente.Email,
                NumeroCartao = dependente.NumeroCartao,
                Parentesco = dependente.Parentesco,
                FkSocio = dependente.Socio.Id
            };

            return dependenteDTO;
        }

        public IEnumerable<DependenteDTO> MapperListEntityToDTO(IEnumerable<Dependente> dependentes)
        {
            IEnumerable<DependenteDTO> dependentesDTO = dependentes.Select(d => new DependenteDTO()
            {
                Id = d.Id,
                Nome = d.Nome,
                Email = d.Email,
                NumeroCartao = d.NumeroCartao,
                Parentesco = d.Parentesco,
                FkSocio = d.Socio.Id
            });

            return dependentesDTO;
        }
    }
}
