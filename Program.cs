//Random name selector app
//Created by: Rico Rodriguez
//Created on: 2022-10-15
//Description: This program will randomly select a name from a list of names

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string[] names = { "Rico", "John", "Bob", "Sally", "Jane", "Mike", "Sue", "Joe", "Mary", "Sara", "Beth" };
            int randomNum;
            Random rnd = new Random();

            //Process
            randomNum = rnd.Next(0, names.Length);

            //Output
            Console.WriteLine("The winner is " + names[randomNum]);
        }
    }
}
