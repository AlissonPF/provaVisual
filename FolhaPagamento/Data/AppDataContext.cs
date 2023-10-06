using FolhaPagamento.Models;
using Microsoft.EntityFrameworkCore;

namespace FolhaPagamento.Data;
public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    {

    }

    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Folha> Folhas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Popule a tabela Funcionario
            modelBuilder.Entity<Funcionario>().HasData(
                new Funcionario { FuncionarioId = 1, Nome = "Alisson", cpf = "08803431926" },
                new Funcionario { FuncionarioId = 2, Nome = "Wendel", cpf = "12285720971" }
                // Adicione mais funcionários conforme necessário
            );

            // Popule a tabela Folha
            modelBuilder.Entity<Folha>().HasData(
                new Folha { Id = 1, Valor = 30, Quantidade = 40, Mes = 2, Ano = 2023, FuncionarioId = 1 },
                new Folha { Id = 2, Valor = 40, Quantidade = 60, Mes = 1, Ano = 2023, FuncionarioId = 2 }
                // Adicione mais folhas conforme necessário
            );
        }
}
