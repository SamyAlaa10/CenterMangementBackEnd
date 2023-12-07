using CenterMangement.Core.Entities;
using CenterMangement.DTO.Entities.User;
using CenterMangement.DTO.Entities.User;
using CenterMangement.Repository.Specifications;
using Control.API;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CenterMangement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IControlBase _controlBase;
        public UserController(IControlBase controlBase)
        {
            _controlBase = controlBase;
        }

        [HttpGet]
        public async Task<UserG> Get(long id)
        {
            return await _controlBase.Get<UserG, User>(id);
        }
        [HttpGet("GetAll")]
        public async Task<IList<UserG>> Get()
        {
            return await _controlBase.Get<UserG, User>();
        }
        [HttpPost]
        public async Task<IActionResult> Add(UserA UserA)
        {
            return Ok(await _controlBase.Add<UserA, User>(UserA));
        }
        [HttpPut]
        public async Task<IActionResult> Ubdate(UserU UserU)
        {
            return Ok(await _controlBase.Update<UserU, User, UserG>(UserU));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(long Id)
        {
            await _controlBase.Remove<User>(Id);
            return Ok();
        }
        [HttpGet("GetWithAllData")]
        public async Task<IList<UserW>> GetWithAll()
        {
            return await _controlBase.GetAllBySpec<UserW, User>(new UserSpecification());
        }
    }
}
