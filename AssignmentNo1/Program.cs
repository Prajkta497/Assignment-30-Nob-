using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo1
{
        //Create a Conaole Application.In this appliation create String Array.
        //The C# Application, should contains method to search a specific name 
        //from string array. Find out all string containing 'a' character in it. 
        //Find out all string having all strings with odd length in it.
    class Program
    {
        static void Main(string[] args)
        {
            List<string> str = new List<string>() { "Prajkta","Prachi","Akash","Kajal","Sam","Leu"};
           //Console.WriteLine("enter the name");
           // string s = Console.ReadLine();
           // Console.WriteLine(str.Contains(s));


           // foreach (var item in str)
           // {

           //     if (item.Contains("a") == true)
           //     {
           //         Console.WriteLine(item);
           //     }
           // }

            foreach (var item in str)
            {
                if(item.Length%2!=0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
