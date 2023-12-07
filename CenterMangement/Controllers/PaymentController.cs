using CenterMangement.Core.Entities;
using CenterMangement.DTO.Entities.Account;
using CenterMangement.DTO.Entities.Payment;
using CenterMangement.DTO.Entities.Payment;
using CenterMangement.Repository.Specifications;
using Control.API;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CenterMangement.API.Controllers
{

    public class PaymentController : BaseApiController
    {
        private readonly IControlBase _controlBase;

        public PaymentController(IControlBase controlBase)
        {
            _controlBase = controlBase;
        }

        [HttpGet]
        public async Task<PaymentG> Get(long id)
        {
            return await _controlBase.Get<PaymentG, Payment>(id);
        }
        [HttpGet("GetAll")]
        public async Task<IList<PaymentG>> Get()
        {
            return await _controlBase.Get<PaymentG, Payment>();
        }
        [HttpPost]
        public async Task<IActionResult> Add(PaymentA PaymentA)
        {
            return Ok(await _controlBase.Add<PaymentA, Payment>(PaymentA));
        }
        [HttpPut]
        public async Task<IActionResult> Ubdate(PaymentU PaymentU)
        {
            return Ok(await _controlBase.Update<PaymentU, Payment, PaymentG>(PaymentU));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(long Id)
        {
            await _controlBase.Remove<Payment>(Id);
            return Ok();
        }
        [HttpGet("GetWithAllData")]
        public async Task<IList<PaymentW>> GetWithAll()
        {
            return await _controlBase.GetAllBySpec<PaymentW, Payment>(new PaymentSpecification());
        }
    }
}
