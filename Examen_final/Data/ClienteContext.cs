using Microsoft.EntityFrameworkCore;
using Examen_final.Models;

namespace Examen_final.Data;

public class ClienteContext : DbContext
{
    public ClienteContext(DbContextOptions<ClienteContext> options) : base(options) { }
    
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<InfoGeneralCliente> InfoGeneralClientes { get; set; }
}
