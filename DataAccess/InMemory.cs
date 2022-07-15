using System;
using System.Collections.Generic;
using Model;
using System.Linq;
namespace DataAccess
{
   public class InMemory
   {
        List<User> _users;
        List<Category> _categories;
        
        public InMemory()
        {
            _users = new List<User>{
          new User{Id=1, UserName="Murat", Password = "12345"},
          new User{Id=2, UserName="Engin", Password = "12345"},
          new User{Id=3, UserName="Kerem", Password = "12345"},
          new User{Id=4, UserName="İbrahim", Password = "12345"}
            };
          _categories = new List<Category>
          {
            new Category{Id = 1, Name="Spor", Like = 10},
            new Category{Id = 2, Name="Müzik", Like = 13},
            new Category{Id = 2, Name="Sinema", Like = 15}
          };
            
        }

      public   User GetByUserName(string user)
      {
         return _users.SingleOrDefault(x => x.UserName == user);
      }
      public void AddUser(User user)
      {
         _users.Add(user);
      }
      public List<User> GetUsers()
      {
         return _users.ToList();
      }

       public List<Category> GetCategories()
       {
           return _categories.ToList();
       }

      
   }
}