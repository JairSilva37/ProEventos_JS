using ProEventos.Domain;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface ILotePersist
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventoId">Método get que retornará uma lista de lotes por evento id</param>
        /// <returns>Lista de lotes</returns>
        Task<Lote[]> GetLotesByEventoIdAsync(int eventoId);

        /// <summary>
        /// Método get que retornará apenas um lote 
        /// </summary>
        /// <param name="eventoId"></param>
        /// <param name="id">Código chave da tabela lote </param>
        /// <returns>Apenas 1 lote</returns>
        Task<Lote> GetLoteByIdsAsync(int eventoId, int id);

    }
}
