using API_Petshop.Repositorio;
using Microsoft.AspNetCore.Mvc;
using API_Petshop.Model;

namespace API_Petshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly GatoRepositorio _gatoRepositorio;
        public ValuesController()
        {
            _gatoRepositorio = new GatoRepositorio();
        }
        [HttpGet]
        //Método GET para retornar gatos cadastrados no banco de dados
        public ActionResult<IEnumerable<Gato>> Get()
        {
            return _gatoRepositorio.GetGatos;
        }
        [HttpPost]
        //Método POST para inserir um gato no banco de dados
        public void Post([FromBody] Gato gato)
        {
            _gatoRepositorio.InserirGato(gato);
        }
        [HttpPut]
        //Método PUT para alterar um gato no banco de dados
        public void Put([FromBody] Gato gato)
        {
            _gatoRepositorio.AlterarGato(gato);
        }
        [HttpDelete]
        //Método DELETE para remover um gato do banco de dados, passando o ID
        public void Delete([FromBody] int id)
        {
            _gatoRepositorio.DeletarGato(id);
        }
    }
}
