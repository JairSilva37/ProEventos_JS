using Microsoft.EntityFrameworkCore;
using ProEvento.API.Models;

namespace ProEventos.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; }
    }
}