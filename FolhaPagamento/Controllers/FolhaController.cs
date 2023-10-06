using FolhaPagamento.Data;
using FolhaPagamento.Models;
using FolhaPagamento.Services;
using Microsoft.AspNetCore.Mvc;

namespace FolhaPagamento.Controllers;

[ApiController]
[Route("api/folha")]
public class FolhaController : ControllerBase
{
    private readonly AppDataContext _ctx;

    public FolhaController(AppDataContext ctx)
    {
        _ctx = ctx;
    }

    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Folha folha)
    {
        try
        {
            _ctx.Folhas.Add(folha);
            _ctx.SaveChanges();
            return Created("", folha);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    [Route("listar")]
    public ActionResult Listar()
    {
        try
        {
            List<Folha> folhas = _ctx.Folhas.ToList();
            if(folhas.Count == 0){
                return NotFound();
            }
            else {
                foreach (Folha folha in folhas)
                {
                    folha.SalarioBruto = (double)(folha.Valor * folha.Quantidade);
                    folha.Inss = FolhaService.CalcularDescontoINSS(folha.SalarioBruto);
                    folha.Ir = FolhaService.CalcularImpostoRenda(folha.SalarioBruto);
                    folha.Fgts = folha.SalarioBruto - (folha.SalarioBruto * 0.08);
                    folha.SalarioLiquido = folha.SalarioBruto - folha.Inss - folha.Ir;
                }
                return Ok(folhas);
            }
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    [Route("buscar/{cpf}/{mes}/{ano}")]
    public ActionResult Buscar([FromRoute] string cpf, int mes, int ano)
    {
        try
        {
            Folha folhaCadastrada = _ctx.Folhas.FirstOrDefault(x => x.Funcionario.cpf == cpf && x.Mes == mes && x.Ano == ano);
            if (folhaCadastrada != null)
            {
                return Ok(folhaCadastrada);
            }
            return NotFound();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
