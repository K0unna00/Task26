using System;
using System.Linq;
using Task26.Data.DAL;
using Task26.Data.Entities;

namespace Task26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task26DbContext MyDB = new Task26DbContext();
            
            Console.WriteLine("Menu \n1.Stadion Elave Et : \n2.Stadiona bax : \n3. ID-e uygun stadiona bax \n4. Stadion Sil");
            int answer = int.Parse(Console.ReadLine());

            bool check = true;
            while (check)
            {
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Stationun bilgilerini yazin : Name , HourPrice , Capacity");
                        string name = Console.ReadLine();
                        int hourPrice = int.Parse(Console.ReadLine());
                        int Capacity = int.Parse(Console.ReadLine());

                        Stadiums stadium = new Stadiums() { Capacity = Capacity, HourPrice = hourPrice, Name = name };
                        MyDB.Stadiums.Add(stadium);
                        MyDB.SaveChanges();
                        check = false;
                        break;
                    case 2:
                        Console.WriteLine("AXtarmaq istediyiniz adi yazin");
                        string answer2 = Console.ReadLine();
                        var Students = MyDB.Users.Where(x => x.Name.Contains(answer2)).FirstOrDefault();
                        Console.WriteLine(Students.Name+ " " + Students.Email);
                        check = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
