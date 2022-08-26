using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Data;
using TestApi.Model;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EcommerceController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EcommerceController(AppDbContext context)
        {
            _context = context;
        }

        [Route("GetCustommer")]
        [HttpGet]
        public IActionResult GetCustommer()
        {
            var data = _context.tb_custommer.ToList();
            return Ok(data);
        }

        [Route("GetAddress")]
        [HttpGet]
        public IActionResult GetAddress()
        {
            var data = _context.tb_custommer_addresses.ToList();
            return Ok(data);
        }

        [Route("GetProduct")]
        [HttpGet]
        public IActionResult GetProduct()
        {
            var data = _context.tb_product.ToList();
            return Ok(data);
        }

        [Route("GetPayment")]
        [HttpGet]
        public IActionResult GetPayment()
        {
            var data = _context.tb_payment_method.ToList();
            return Ok(data);
        }

        [Route("CreateTransaksi")]
        [HttpPost]
        public IActionResult CreateTransaksi(transaksi transaksi)
        {
            transaksi.id = 1;
            _context.tb_transaksi.Add(transaksi);
            _context.SaveChanges();
            return Ok(transaksi);
        }
    }
}
