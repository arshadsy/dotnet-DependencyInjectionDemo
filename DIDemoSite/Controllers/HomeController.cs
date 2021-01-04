using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIDemoSite.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIDemoSite.Controllers
{
    [Route("[Controller]/[Action]")]
    public class HomeController : Controller
    {
        IDataRepo _repo;
        public HomeController(IDataRepo repo)
        {
            _repo = repo;
        }
        public IActionResult GetNames()
        {
            return Ok(_repo.GetData());
        }
        public IActionResult AcceptData(IDataRepo dataRepo)
        {
            return Ok(dataRepo);
        }
    }
}