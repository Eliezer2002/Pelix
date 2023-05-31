using Microsoft.AspNetCore.Mvc;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pelix.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroPeliculaController : ControllerBase
    {
        private readonly IGeneroPeliculaRepository generoPeliculaRepository;

        public GeneroPeliculaController(IGeneroPeliculaRepository generoPeliculaRepository)
        {
            this.generoPeliculaRepository = generoPeliculaRepository;
        }
        // GET: api/<GeneroPeliculaController>
        [HttpGet]
        public IEnumerable<GeneroPeliculaModel> Get()
        {
            return generoPeliculaRepository.GetAll();
        }

        // GET api/<GeneroPeliculaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GeneroPeliculaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GeneroPeliculaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GeneroPeliculaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
