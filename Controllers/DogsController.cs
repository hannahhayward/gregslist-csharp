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

      public DogsController(DogsService ds)
      {
        _ds = ds;
      }
    [HttpGet]
    public List<Dog> GetDogs()
    {
      return _ds.GetAll();
    }
    [HttpPost]
    public ActionResult<Dog> CreateDog([FromBody] Dog dogData){
      try
      {
        var dog = _ds.createDog(dogData);
        return Created("api/dogs/" + dog.Id, dog);
      }
      catch(System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Dog> EditDog(int id, [FromBody] Dog dogData){
      try{
        var dog = _ds.editDog(id, dogData);
        return dog;
      }
      catch (System.Exception e){
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<Dog> RemoveDog(int id){
      try{
        var dog = _ds.removeDog(id);
        return  Ok(dog);
      }
      catch (System.Exception e){
        return BadRequest(e.Message);
      }
    }
  }
}