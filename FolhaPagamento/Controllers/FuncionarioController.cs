using FolhaPagamento.Data;
using FolhaPagamento.Models;
using Microsoft.AspNetCore.Mvc;

namespace FolhaPagamento.Controllers;

[ApiController]
[Route("api/funcionario")]
public class FuncionarioController : ControllerBase
{
    private readonly AppDataContext _ctx;

    public FuncionarioController(AppDataContext ctx)
    {
        _ctx = ctx;
    }

    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Funcionario funcionario)
    {
        try
        {
            _ctx.Funcionarios.Add(funcionario);
            _ctx.SaveChanges();
            return Created("", funcionario);
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
            List<Funcionario> funcionarios = _ctx.Funcionarios.ToList();
            return funcionarios.Count == 0 ? NotFound() : Ok(funcionarios);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
