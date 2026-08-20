using Microsoft.AspNetCore.Mvc;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        [HttpPost]
        public IActionResult CalcularIMC(string nome, double peso, double altura)
        {
            double imc = peso / (altura * altura);

            return Ok(new
            {
                Nome = nome,
                Peso = peso,
                Altura = altura,
                IMC = imc
            });
        }
    }
}