﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FMPI.Sales.Application.Products;
using FMPI.Sales.Application.Products.Dto;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FMPI.Sales.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<ProductOutputDto> Get()
        {
            var productAppService = new ProductAppService();
            return productAppService.GetProducts();
            //return new string[] { "value1", "value2", "value3"};
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
