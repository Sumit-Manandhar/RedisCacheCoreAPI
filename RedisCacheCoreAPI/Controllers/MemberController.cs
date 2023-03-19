using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedisCacheCoreAPI.Models;

namespace RedisCacheCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {

        public MemberController() { }

        public ReturnModel GetList()
        {
            return new ReturnModel
            {
                message = "success",
                success = true,

            };
        }
    }
}
