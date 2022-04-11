using System;

namespace NewHomework999
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deyer Daxil Edin");
            string b = Console.ReadLine();
           

            while (true)
            {


                if (b.Length >= 8)
                {

                    
                    break;
                }
                else
                {

                    Console.WriteLine("Yeniden daxil edin");
                    b = Console.ReadLine();
                }
            }


            User user1 = new User(b);

            Console.WriteLine("Password deyerini daxil edin");
            user1.Password = Console.ReadLine();
            Console.WriteLine("Istifadeci passwordu: " + user1.Password);
            
            
        }
    }
}
