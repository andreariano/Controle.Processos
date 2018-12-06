using System.Collections.Generic;
using System.Threading.Tasks;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Processos;
using Controle.Processos.Domain.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Processos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessosController : ControllerBase
    {
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IListProcessoQuery _listProcessoQuery;

        public ProcessosController(IListProcessoQuery listProcessoQuery, IQueryDispatcher queryDispatcher)
        {
            _queryDispatcher = queryDispatcher;
            _listProcessoQuery = listProcessoQuery;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IList<Processo>>> Get()
        {
            return Ok(await _queryDispatcher.SendQuery(_listProcessoQuery));
        }

//        // GET api/values/5
//        [HttpGet("{id}")]
//        public ActionResult<string> Get(int id)
//        {
//            return "value";
//        }
//
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