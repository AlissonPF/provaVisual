namespace FolhaPagamento.Models;
public class Folha
{
    public int Id { get; set; }
    public decimal Valor { get; set; }
    public int Quantidade { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
    public double SalarioBruto { get; set; }
    public double Inss { get; set; }
    public double Fgts { get; set; }
    public double Ir { get; set; }
    public double SalarioLiquido { get; set; }
    public int FuncionarioId { get; set; }
    public Funcionario? Funcionario { get; set; }
}
