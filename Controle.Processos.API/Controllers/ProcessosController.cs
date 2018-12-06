using System.Collections.Generic;
using System.Threading.Tasks;
using Controle.Processos.DI.Bus;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Processos;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Processos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessosController : ControllerBase
    {
        private readonly IBus _bus;
        private readonly IListProcessoRequest _listProcessoRequest;

        public ProcessosController(IBus bus, IListProcessoRequest listProcessoRequest)
        {
            _bus = bus;
            _listProcessoRequest = listProcessoRequest;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IList<Processo>>> Get()
        {
            return Ok(await _bus.Send(_listProcessoRequest));
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