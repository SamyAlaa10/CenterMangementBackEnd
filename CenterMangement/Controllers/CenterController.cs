using CenterMangement.Core.Entities;
using CenterMangement.DTO.Entities.Center;
using CenterMangement.Repository.Specifications;
using Control.API;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CenterMangement.API.Controllers
{
    public class CenterController : BaseApiController
    {
        private readonly IControlBase _controlBase;

        public CenterController(IControlBase controlBase)
        {
            _controlBase = controlBase;
        }

        [HttpGet]
        public async Task<CenterG> Get(long id)
        {
            return await _controlBase.Get<CenterG, Center>(id);
        }
        [HttpGet("GetAll")]
        public async Task<IList<CenterG>> Get()
        {
            return await _controlBase.Get<CenterG, Center>();
        }
        [HttpPost]
        public async Task<IActionResult> Add(CenterA CenterA)
        {
            return Ok(await _controlBase.Add<CenterA, Center>(CenterA));
        }
        [HttpPut]
        public async Task<IActionResult> Ubdate(CenterU CenterU)
        {
            return Ok(await _controlBase.Update<CenterU, Center, CenterG>(CenterU));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(long Id)
        {
            //await _controlBase.RemoveBySpec<User>(new UserSpecification(x => x.IdCenter == Id));
            //await _controlBase.RemoveBySpec<Payment>(new PaymentSpecification(x => x.IdCenter == Id));
            await _controlBase.Remove<Center>(Id);
            return Ok();
        }
        [HttpGet("GetWithAllData")]
        public async Task<IList<CenterW>> GetWithAll()
        {
            return await _controlBase.GetAllBySpec<CenterW, Center>(new CenterSpecification());
        }
    }
}
