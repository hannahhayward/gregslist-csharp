using System.Collections.Generic;
using gregslist_csharp.Models;
using Microsoft.AspNetCore.Mvc;
using gregslist_csharp.Services;

namespace gregslist_csharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogsController: ControllerBase{
      private readonly DogsService _ds;

      public DogsController(DogsService ds){
        _ds = ds;
      }
    }
}