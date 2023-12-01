using Microsoft.EntityFrameworkCore;
using ASP_NET_MVC.Models;

namespace ASP_NET_MVC.Context
{
    // Classe responsável por acessar o DB
    public class Context : DbContext
    {
        // Recebe a conexão com o DB e transfere para a classe base que inicia a conexão
        public Context(DbContextOptions<Context> options) : base(options)
        {}

        // Entidades DbSet -> classe no programa e uma tabela no DB
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Cargos> Cargos { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
    }
}
