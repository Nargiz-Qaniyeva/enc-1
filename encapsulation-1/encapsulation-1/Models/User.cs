using System;
using System.Collections.Generic;
using System.Text;

namespace encapsulation_1.Models
{
    internal class User
    {
        public string UserName;
        private int Age;
        private int Password;

        public int age {
            get
            {
                return age; 
            } 
            set 
            {
                if (value  < 0)
                {
                    Console.WriteLine("duzgun deyil!!!");
                    return;
                }
                Age = value ;
                Console.WriteLine("set olundu");
            }
        }

        public int myPassword {
            get
            {
                    return 0;
            }
            set 
            {
                
            }
        }

        public User()
        {

        }
        public User(string UserName, int Age, int Password)
        {
            this.UserName= UserName;    
            this.Age= Age;  
            this.Password= Password;
        }

        //public void setAge(int yas)
        //{
        //    if (yas<0)
        //    {
        //        Console.WriteLine("duzgun deyil!!!");
        //        return;
        //    }
        //    Age= yas;
        //    Console.WriteLine("set olundu");
            
        //}
    }
}
