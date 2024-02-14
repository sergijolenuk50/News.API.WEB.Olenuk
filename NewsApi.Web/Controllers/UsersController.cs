using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;
using NewsApi.Core.Services;

namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersServices _usersService;
        public UsersController(IUsersServices usersServices)
        {
            _usersService = usersServices; 
        }

      
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll1()
        {
            var news = await _usersService.GetAll();
            return Ok(news);
        }
        [HttpPost("GetId")]
        public async Task<IActionResult> GetById(int id)
        {
            var news = await _usersService.Get(id);
            return Ok(news);
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(Users Model)
        {
            await _usersService.Insert(Model);
            return Ok();
        }
        [HttpPost("Update")]
        public async Task<IActionResult> Update(Users Model)
        {
            await _usersService.Update(Model);
            return Ok();
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _usersService.Delete(id);
            return Ok();
        }
    }
}
