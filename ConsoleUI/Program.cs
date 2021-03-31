﻿using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (object car in carManager.GetAll())
            {
                Console.WriteLine("Hello World!");
            }
            
            
           
        }
    }
}
