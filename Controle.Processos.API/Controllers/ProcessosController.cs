using System.Collections.Generic;
using System.Threading.Tasks;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Processos;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Processos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessosController : ControllerBase
    {
        private readonly IListProcessoQuery _listProcessoQuery;

        public ProcessosController(IListProcessoQuery listProcessoQuery)
        {
            _listProcessoQuery = listProcessoQuery;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Processo>>> GetAll()
        {
            return Ok(await 
                _listProcessoQuery
                .Run());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IList<Processo>>> Get(int id)
        {
            return Ok(await 
                _listProcessoQuery
                .WithNumeroProcesso(id)
                .Run());
        }

//        // POST api/values
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }
//
//        // PUT api/values/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }
//
//        // DELETE api/values/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
    }
}