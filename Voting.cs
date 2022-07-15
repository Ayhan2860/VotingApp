using DataAccess;
using System.Linq;
using System.Collections.Generic;
using Model;
using System;
public class Voting
{
  public static void Switcher()
  {
      Console.WriteLine("Oy Vermek İstediğiniz Kategoriyi Seçiniz"+
                        "\nMüzik  için   1"+
                        "\nSpor   için   2"+
                        "\nSinema için   3\n");
       Console.Write("Seçiminiz : ");
      int vote = Convert.ToInt32(Console.ReadLine());
      Console.Clear();
      Console.WriteLine("1 ile 10 Arasında bir puan belirleyin\n");
      bool wh = true;
      while(wh)
      {
        
        Console.Write("Puanınız : ");
         double puan = Convert.ToDouble(Console.ReadLine());
        if(puan < 1 || puan > 10)
        {
           

            Console.WriteLine("Puanınız 1 ile 10 arasında olmalıdır");
        }
        else
        {
            switch(vote)
            {
                case 1: LikeVoting("Müzik", puan); break;
                case 2: LikeVoting("Spor", puan); break;
                case 3: LikeVoting("Sinema", puan); break;
            default:break;
            }
            wh = false;
       }
      }
      
      
  }

  
  public static void LikeVoting(string name, double puan)
  {
     List<Category> categories = new InMemory().GetCategories();
     var category = categories.SingleOrDefault(x => x.Name == name);
    
     category.Like += puan;
  
     GetVoting(categories);
  
  }


  
   public static void GetVoting(List<Category> categories)
  {
    Console.WriteLine("\n");
    double result = 0;
     Console.WriteLine("Rakamsal Sonuçlar :");
    for(int i = 0; i<categories.Count; i++)
    {
       result += categories[i].Like;
       Console.WriteLine($"{categories[i].Name} =>  {categories[i].Like:F1}");
    }
     Console.WriteLine("\nYüzdesel Sonuçlar :");
    for(int i = 0; i<categories.Count; i++)
    {
       double r  = categories[i].Like / result *100;
       Console.WriteLine($"%{categories[i].Name} =>  {r:F1}");
    }
    Console.WriteLine("\nÇıkmak için bir tuşa basınız\n");
    Console.ReadKey();
  }
}