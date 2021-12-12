using FullStackMVC.BLL.UserLogic;
using FullStackMVC.DAL.Context;
using FullStackMVC.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace SPA.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        DataContext _context;
        UserLogic user;

        public UserController(IConfiguration config, DataContext context)
        {
            _config = config;
            _context = context;
            user = new UserLogic(_context);
        }

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(user.GetAll());
        }

        [HttpPost]
        public async Task<JsonResult> Post(User userPost)
        {
            if (ModelState.IsValid)
            {
                user.Add(userPost);
                await user.SaveChangeAsync();
                return new JsonResult("Added Successfully");
            }
            return new JsonResult("Oops!");
        }

        [HttpPut]
        public async Task<JsonResult> Put(User userPut)
        {
            if (ModelState.IsValid)
            {
                user.Update(userPut);
                await user.SaveChangeAsync();
                return new JsonResult("Updated Successfully");
            }
            return new JsonResult("Oops!");
        }

        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(int id)
        {
            var u = await user.GetByIdAsync(id);
            if(u == null)
            {
                return new JsonResult("Oops!");
            }
            user.Remove(u);
            await user.SaveChangeAsync();
            return new JsonResult("Deleted Successfully");
        }
    }
}
