using AutoMapper;
using CenterMangement.Core.Entities;
using CenterMangement.Core.Repostiories;
using CenterMangement.DTO.Entities.Account;
using CenterMangement.Repository.Specifications;
using Control.API;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CenterMangement.API.Controllers
{

    public class AccountController : BaseApiController
    {
        private readonly IControlBase _controlBase;

        public AccountController(IControlBase controlBase)
        {
            _controlBase = controlBase;
        }

        [HttpGet]
        public async Task<AccountG> Get(long id)
        {
            return await _controlBase.Get<AccountG, Account>(id);
        }
        [HttpGet("GetAll")]
        public async Task<IList<AccountG>> Get()
        {
            return await _controlBase.Get<AccountG, Account>();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AccountA accountA)
        {
            return Ok(await _controlBase.Add<AccountA, Account>(accountA));
        }
        [HttpPut]
        public async Task<IActionResult> Ubdate(AccountU accountU)
        {
            return Ok(await _controlBase.Update<AccountU, Account,AccountG>(accountU));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(long Id)
        {
            await _controlBase.RemoveBySpec<User>(new UserSpecification(x=>x.IdAccount==Id));
            await _controlBase.RemoveBySpec<Payment>(new PaymentSpecification(x=>x.IdAccount==Id));
            await _controlBase.Remove<Account>(Id);
            return Ok();
        }
        [HttpGet("GetWithAllData")]
        public async Task<IList<AccountW>> GetWithAll()
        {
            return await _controlBase.GetAllBySpec<AccountW, Account>(new AccountSpecification());
        }
    }
}
