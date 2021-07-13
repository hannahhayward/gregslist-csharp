using System.Collections.Generic;
using gregslist_csharp.Data;
using gregslist_csharp.Models;

namespace gregslist_csharp.Services
{
    public class CatsService{
      public List<CatsService> GetAll(){
        return FakeDb.Cats;
      }
    }
}