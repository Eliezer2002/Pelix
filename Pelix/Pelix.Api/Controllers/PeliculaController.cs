using Microsoft.AspNetCore.Mvc;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using Pelix.DAL.Repositories;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pelix.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private readonly IPeliculaRepository peliculaRepository;

        public PeliculaController(IPeliculaRepository _peliculaRepository)
        {
            peliculaRepository = _peliculaRepository;
        }
        // GET: api/<PeliculaController>
        [HttpGet]
        public IEnumerable<PeliculaModel> Get()
        {
            return peliculaRepository.GetAll();
        }

        // GET api/<PeliculaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PeliculaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PeliculaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PeliculaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
