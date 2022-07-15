using System;
using DataAccess;
using Model;

public class Auth
{
  
   public static void Register(User user)
   {
       InMemory inMemory =  new InMemory();
       if(inMemory.GetByUserName(user.UserName) == null)
       {
            inMemory.AddUser(user);
         Console.WriteLine("Kullanıcı Kaydedildi");
         
       }
        else 
       Console.WriteLine("Kullanıcı Mevcut");
   }

   static public bool Login(string userName, string password)
   {
      InMemory inMemory =  new InMemory();
       bool result = true;
       var user = inMemory.GetByUserName(userName);
       if(user != null)
       {
           if(user.UserName == userName && user.Password == password)
            result = true;
            else
            {
               Console.WriteLine("Bilgilerinizi Kontrol Ediniz!");
               result = false;
            }
       }
        else{
          Console.WriteLine("Kullanıcı Kaydı Bulunamadı!");
          result = false;
        }

       return result;
   }

  
}