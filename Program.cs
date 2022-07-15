using System;
using Model;

namespace VotingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı Bilgilerinizi Griniz \n");
     Console.Write("Kullanıcı Adınız : ");
     string userName = Console.ReadLine();
     Console.Write("Parolanız : ");
     string password = Console.ReadLine();
     var isLogin = Auth.Login(userName, password);
     if(!isLogin)
     {
       Console.Clear();
       Console.WriteLine("Kayıt Olmak İçin  Bir Tuşa Basınız!");
       Console.ReadKey();
       int id = new Random().Next(10, 100);


        Console.Write("Kullanıcı Adınız : ");
       string newUserName = Console.ReadLine();
        Console.Write("Parolanız : ");
       string newPassword = Console.ReadLine();
       Auth.Register(new User {Id = id, UserName = newUserName, Password= newPassword} );
       Console.Clear();
       Console.WriteLine("Oylamaya devat etmek için bir tuşa basınız");
       Console.ReadKey();
       Voting.Switcher();
       
     }
    else{
      Console.WriteLine("Hoş Geldiniz {0}", userName);
      Voting.Switcher();
    }
        }
    }
}
