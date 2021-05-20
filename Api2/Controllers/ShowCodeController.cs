using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api2.Controllers
{
    [Route("api2/showcode")]
    [ApiController]
    public class ShowCodeController : ControllerBase
    {

        [HttpGet]
        [Route("showmethecode")]
        public async Task<string> ShowmeTheCode()
        {
            var urlGithubProjeto = "teste";
            return urlGithubProjeto;
        }
    }
}
