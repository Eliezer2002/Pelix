using Microsoft.AspNetCore.Mvc;
using Pelix.BL.Contract;
using Pelix.BL.Dtos.Sale;
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
        private readonly ISaleService saleService;

        public SaleController(ISaleService saleService)
        {
            this.saleService = saleService;
        }
        // GET: api/<SaleController>
        [HttpGet ("ObtenerSales")]
        public IActionResult Get()
        {
            var result = saleService.GetAll();
            if (result.Success) 
            {
                return Ok(result);
            }
            else 
            { 
                return BadRequest(); 
            }
        }

        // GET api/<SaleController>/5
        [HttpGet("\"ObtenerRents\"{id}")]
        public IActionResult Get(int id)
        {
            var result = saleService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST api/<SaleController>
        [HttpPost("GuardarSale")]
        public IActionResult Post([FromBody] SaleSaveDto sale)
        {
            var result = saleService.SaveSale(sale);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/<SaleController>/5
        [HttpPut("ActualizarSale")]
        public IActionResult Put([FromBody] SaleUpdateDto sale)
        {
            var result = saleService.UpdateSale(sale);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<SaleController>/5
        [HttpDelete("EliminarSale")]
        public IActionResult Delete([FromBody] SaleRemoveDto id)
        {
            var result = saleService.RemoveSale(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
