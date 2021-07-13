using System;
using System.Collections.Generic;
using gregslist_csharp.Controllers;
using gregslist_csharp.Data;
using gregslist_csharp.Models;

namespace gregslist_csharp.Services
{
    public class DogsService{
      public List<Dog> GetAll(){
        return FakeDb.Dogs;
      }
      public Dog createDog(Dog dogData){
        var r = new Random();
        dogData.Id = r.Next(100, 10000);
        FakeDb.Dogs.Add(dogData);
        return dogData;
      }
      public Dog editDog(int id, Dog dogData){
        var dog = FakeDb.Dogs.Find(d => d.Id == id);
        if(dog == null){
          throw new Exception("not a dog");
        }
        FakeDb.Dogs.Add(dogData);
        return dog;
      }
      public Dog removeDog(int id){
        var dog = FakeDb.Dogs.Find(d => d.Id == id);
        if (dog == null){
          throw new Exception("not a dog");
        }
        FakeDb.Dogs.Remove(dog);
        return dog;
      }
    }
}