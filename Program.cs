﻿using LibraryCardCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CTLCCFile1
{
    class Program
    {
        static void Main(string[] args)
        {

            // prompt user to enter the name of a file

            //this file will be used to save all the information
            //in the application when the user closes it

            Console.WriteLine("Please enter a file name:");
            string userFileName = Console.ReadLine();
            CardCatalog a = new CardCatalog(userFileName);


            //user is presented with a numeric list of options
            //user should be able to enter a numeric choice

            //if user enters 1 or 2 then menu should redisplay
            //if user enters 3 then menu should close

            int number = 0;
            while (number != 3)
            {


                Console.WriteLine("Please Select an Option from the Menu:");
                Console.WriteLine("1.List All Books");
                Console.WriteLine("2.Add A Book");
                Console.WriteLine("3.Save And Exit");



                number = Convert.ToInt32(Console.ReadLine());


                switch (number)
                {

                    case 1:
                        a.ListBooks();
                        break;

                    case 2:
                        a.AddBook();
                        break;

                    case 3:
                        // Save Method should be placed here
                        break;
                    default:
                        Console.WriteLine("Sorry, invalid selecton. Please enter 1, 2 or 3");
                        break;


                }
            }


        }
    }
}
