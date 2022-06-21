using Cymax.Model;
using Cymax;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CymaxService;
using Microsoft.Extensions.Configuration;

namespace CymaxAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : Controller
    {
        private IConfiguration configuration;
        // GET: ProcessController

        /// <summary>
        ///  Below is the method to find out the minimum rate .
        /// </summary>
        /// <param name="shipmentDto"></param>
        /// <returns></returns>

        //[HttpGet("[action]")]
        //public ActionResult GetLesserQuote(ShipmentInputDto shipmentDto)
        //{
        //    if (shipmentDto == null)
        //        return BadRequest("No input specified!");
        //    string FromAddress = configuration.GetSection("ShipmentInputObj1").GetSection("ContactAdress").Value;
        //    string ToAddress = configuration.GetSection("ShipmentInputObj1").GetSection("WareHouseAddress").Value;
        //    ShipmentService shipObj = new ShipmentService();
           
        //    long result = Math.Min(shipObj.GetTotal(shipmentDto, FromAddress ,ToAddress).Total, Math.Min(shipObj.GetAmount(shipmentDto).Amount, shipObj.GetQuote(shipmentDto).Quote));

        //    return Ok(result);
        //}


        [HttpGet("[action]")]
        public  ActionResult GetTotal(ShipmentInputDto shipmentDto)
        {
            if (shipmentDto == null)
                return BadRequest("No input specified!");
            ShipmentService shipObj = new ShipmentService();
            string FromAddress = configuration.GetSection("ShipmentInputObj1").GetSection("ContactAdress").Value;
            string ToAddress = configuration.GetSection("ShipmentInputObj1").GetSection("WareHouseAddress").Value;


            return  Ok(shipObj.GetTotal(shipmentDto, FromAddress, ToAddress).Total);
        }

        [HttpGet("[action]")]
        public ActionResult GetAmount(ShipmentInputAPI2 shipmentDto)
        {
            if (shipmentDto == null)
                return BadRequest("No input specified!");
            ShipmentService shipObj = new ShipmentService();
            string FromAddress = configuration.GetSection("ShipmentInputObj1").GetSection("ContactAdress").Value;
            string ToAddress = configuration.GetSection("ShipmentInputObj1").GetSection("WareHouseAddress").Value;


            return Ok(shipObj.GetAmount(shipmentDto, FromAddress, ToAddress).Amount);
        }

        [HttpGet("[action]")]
        public ActionResult GetQuote(ShipmentInputAPI3 shipmentDto)
        {
            if (shipmentDto == null)
                return BadRequest("No input specified!");
            ShipmentService shipObj = new ShipmentService();
            string FromAddress = configuration.GetSection("ShipmentInputObj1").GetSection("ContactAdress").Value;
            string ToAddress = configuration.GetSection("ShipmentInputObj1").GetSection("WareHouseAddress").Value;

            return Ok(shipObj.GetQuote(shipmentDto, FromAddress, ToAddress).Quote);
        }
    }
}
