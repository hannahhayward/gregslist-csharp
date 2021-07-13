using gregslist_csharp.Services;
using gregslist_csharp.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace  gregslist_csharp.Controllers{
  [ApiController]
  [Route("api/[controller]")]
public class CatsController: ControllerBase{
  private readonly CatsService _cs;
  public CatsController(CatsService cs){
    _cs = cs;
  }
  [HttpGet]
  public List<Cat> GetCats(){
    return _cs.GetAll();
  }
  [HttpPost]
  public ActionResult<Cat> CreateCat([FromBody] Cat catData){
    try{
      var cat = _cs.createCat(catData);
      return Created("api/cats/" + cat.Id, cat);
    }
    catch(System.Exception e){
      return BadRequest(e.Message);
    }
  }
}
}