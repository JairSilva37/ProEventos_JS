using ProEventos.Domain;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);
        Task<Palestrante> GetAllPalestranteByIdAsync(int palestranteId, bool includeEventos);


    }
}
