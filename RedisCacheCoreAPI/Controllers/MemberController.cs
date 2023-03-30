using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedisCacheCoreAPI.Models;
using Services.Iservices;
using Services.Services;

namespace RedisCacheCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberServices;
        public MemberController(IMemberService service) {
            _memberServices = service;
        }
        [HttpPost]
        [Route("getList")]
        [AllowAnonymous]
        public ReturnModel GetList()
        {
            var data =_memberServices.getLists();
            return new ReturnModel
            {
                message = "success",
                success = true,
                data=data
            };
        }
    }
}
