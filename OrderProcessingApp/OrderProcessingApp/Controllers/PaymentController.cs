using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderAppCommon.Interface;
using OrderAppCommon.Model;

namespace OrderProcessingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentsService;

        public PaymentController(IPaymentService paymentsService)
        {
            _paymentsService = paymentsService;
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(IEnumerable<PaymentType>))]
        [ProducesResponseType(404)]
        [ProducesResponseType(406)]
        public async Task<IActionResult> ProcessPayment(PaymentType payment)
        {
            try
            {
                var response = await _paymentsService.PaymentProcess(payment.SelectedItem);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}