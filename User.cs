using System;
using System.Collections.Generic;
using System.Text;

namespace NewHomework999
{
    class User
    {
        public string UserName;
        private string _password;
        public string Password
        {
            get
            {
                return _password;


            }
            set
            {
                
                int countupper = 0;
                int countlower = 0;
                int countdigit = 0;
                while (true)
                {

                    if (value.Length >= 8)
                    {
                        foreach (char item in value)
                        {
                            if (char.IsUpper(item))
                            {
                                countupper++;
                                

                            }
                            else if(char.IsLower(item))
                            {
                                countlower++;
                                

                            }
                            else if(char.IsDigit(item))
                            {
                                countdigit++;
                                

                            }

                        }
                        if (countdigit != 0 && countlower !=0 && countupper !=0)
                        {

                            _password = value;
                            

                            break;


                        }
                        if (countdigit == 0 || countlower == 0 || countupper == 0)
                        {
                            Console.WriteLine("Duzgun deyer daxil et");
                            value = Console.ReadLine();
                            
                        }





                        

                    }
                    else
                    {
                        Console.WriteLine("Yeniden daxil et");
                        value = Console.ReadLine();
                        
                        
                    }




                }   

                    
                



            }
        }
        public User(string username)
        {
            UserName = username;
            Console.WriteLine("Istifadeci Username: " + UserName);
        }







       
    }
}
