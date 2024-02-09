using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;
using NewsApi.Core.Services;

namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleServices _roleServices;
        public RoleController(IRoleServices roleServices)
        {
            _roleServices = roleServices;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll1()
        {
            var news = await _roleServices.GetAll();
            return Ok(news);
        }
        [HttpPost("GetId")]
        public async Task<IActionResult> GetById(int id)
        {
            var news = await _roleServices.Get(id);
            return Ok(news);
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(Role Model)
        {
            await _roleServices.Insert(Model);
            return Ok();
        }
        [HttpPost("Update")]
        public async Task<IActionResult> Update(Role Model)
        {
            await _roleServices.Update(Model);
            return Ok();
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _roleServices.Delete(id);
            return Ok();
        }
    }
}
