using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.Mappers;
using ClubeApi.Domain.Models;

namespace ClubeApi.Application.Mappers
{
    public class MapperMensalidade : IMapperMensalidade
    {
        public Mensalidade MapperDTOToEntity(MensalidadeDTO mensalidadeDTO)
        {
            Mensalidade mensalidade = new Mensalidade()
            {
                Id = mensalidadeDTO.Id,
                DataVencimento = mensalidadeDTO.DataVencimento,
                ValorInicial = mensalidadeDTO.ValorInicial,
                DataPagamento = mensalidadeDTO.DataPagamento,
                Juros = mensalidadeDTO.Juros,
                ValorFinal = mensalidadeDTO.ValorFinal,
                Quitada = mensalidadeDTO.Quitada,
            };

            return mensalidade;
        }

        public MensalidadeDTO MapperEntityToDTO(Mensalidade mensalidade)
        {
            MensalidadeDTO mensalidadeDTO = new MensalidadeDTO()
            {
                Id = mensalidade.Id,
                DataVencimento = mensalidade.DataVencimento,
                ValorInicial = mensalidade.ValorInicial,
                DataPagamento = mensalidade.DataPagamento,
                Juros = mensalidade.Juros,
                ValorFinal = mensalidade.ValorFinal,
                Quitada = mensalidade.Quitada,
            };

            return mensalidadeDTO;
        }

        public IEnumerable<MensalidadeDTO> MapperListEntityToDTO(IEnumerable<Mensalidade> mensalidades)
        {
            IEnumerable<MensalidadeDTO> mensalidadesDTO = mensalidades.Select(m => new MensalidadeDTO()
            {
                Id = m.Id,
                DataVencimento = m.DataVencimento,
                ValorInicial = m.ValorInicial,
                DataPagamento = m.DataPagamento,
                Juros = m.Juros,
                ValorFinal = m.ValorFinal,
                Quitada = m.Quitada,
            });

            return mensalidadesDTO;
        }
    }
}
