using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.Services;
using NewsApi.Core.Interfaces;
using NewsApi.Core.Entities;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
       private readonly INewsServices _newsService;
        private readonly IUsersServices _usersService;
       public NewsController(INewsServices newsService, IUsersServices usersService)
       {
           _newsService = newsService;
           _usersService = usersService;
       }
       [HttpGet("GetAll")]
       public async Task<IActionResult> GetAll()
       {
         //  var news = new
         //  {
         //      Title = "Microsoft Office’s RTC (Real-Time Channel) migration to modern .NET",
         //      Description = "Real-Time Channel (RTC) is Microsoft Office Online’s websocket service that powers the real-time collaboration experiences for Office applications. It serves hundreds of millions of document sessions per day from dozens of datacenters and thousands of server VMs around the world.",
         //      Text = "Real-Time Channel (RTC) is Microsoft Office Online’s websocket service that powers the real-time collaboration experiences for Office applications. It serves hundreds of millions of document sessions per day from dozens of datacenters and thousands of server VMs around the world.\r\n\r\nThe service was written in .NET Framework (4.7.2) with IIS and ASP.NET. It is mainly built around a SignalR service providing real-time communication and has additional functionality like routing, session management, and notifications."
         //  };
           var  news = await _newsService.GetAll();
           return  Ok(news);
       }
     
     
       [HttpPost("GetId")]
       public async Task<IActionResult> GetById(int id)
       {
           var news = await _newsService.Get(id);
           return Ok(news);
       }
       [HttpPost("Insert")]
       public async Task<IActionResult> Insert(News Model)
       {
           await _newsService.Insert(Model);
           return Ok();
       }
       [HttpPost("Update")]
       public async Task<IActionResult> Update(News Model)
       {
           await _newsService.Update(Model);
           return Ok();
       }
       [HttpDelete("Delete")]
       public async Task<IActionResult> Delete(int id)
       {
            await _newsService.Delete(id);
           return Ok();
       }
    }
}
