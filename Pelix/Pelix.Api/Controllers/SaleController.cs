using Microsoft.AspNetCore.Mvc;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using Pelix.DAL.Repositories;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pelix.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleRepository saleRepository;

        public SaleController(ISaleRepository saleRepository)
        {
            this.saleRepository = saleRepository;
        }
        // GET: api/<SaleController>
        [HttpGet]
        public IActionResult Get()
        {
            var Sales = saleRepository.GetAll();
            return Ok(Sales);
        }

        // GET api/<SaleController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var sale= saleRepository.GetbyId(id);
            return Ok(sale);
        }

        // POST api/<SaleController>
        [HttpPost]
        public IActionResult Post([FromBody] Sale sale)
        {
            saleRepository.Save(sale);
            saleRepository.SaveChanges();
            return Ok();
        }

        // PUT api/<SaleController>/5
        [HttpPut()]
        public IActionResult Put([FromBody] Sale sale)
        {
            saleRepository.Update(sale);
            saleRepository.SaveChanges();
            return Ok();
        }

        // DELETE api/<SaleController>/5
        [HttpDelete()]
        public IActionResult Delete([FromBody] Sale id)
        {
            saleRepository.Remove(id);
            saleRepository.SaveChanges();
            return Ok();
        }
    }
}
