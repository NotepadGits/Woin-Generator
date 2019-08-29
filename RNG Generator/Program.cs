using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNG_Generator
{
    class Program
    {

       


        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<string> W_Type = new List<string>();
            List<string> Weapons_Passed = new List<string>();
            List<string> Weapon_Quantity = new List<string>();


            W_Type.Add("Pistol      ");
            W_Type.Add("PDW         ");
            W_Type.Add("SMG         ");
            W_Type.Add("Rifle       ");
            W_Type.Add("Carbine     ");
            W_Type.Add("LMG         ");
            W_Type.Add("Ex_Ordinance");
            W_Type.Add("Support     ");
            // What weapons are each company going to make



            Console.WriteLine("Company weapon types T/F >> \n");

            for (int i = 0; i < W_Type.Count(); i++)
            {
                Console.Write(W_Type[i]);
                if (rnd.Next(1, 4) == 1)
                {
                    Console.Write(": \tTrue\n");
                    Weapons_Passed.Add(W_Type[i]);          // add the weapons which are being made to a new list
                }
                else Console.Write(": \tFlase\n");
            }

            Console.Write("\n\n\n");
            for (int i = 0; i < Weapons_Passed.Count(); i++) // list which weapons are being made
            {
                Console.Write("\n" + Weapons_Passed[i]);
            }

            for (int i = 0; i < Weapons_Passed.Count(); i++) // create quantity of weapons
            {
                
                for (int I = 0; I <= rnd.Next(1, 6); I++)
                {
                    Weapon_Quantity.Add(Weapons_Passed[i]);
                }

            }
            Console.Write("\n\n\n");

            // create each weapons statline
            for (int i = 0; i < Weapon_Quantity.Count(); i++)
            {
                Console.Write(Weapon_Quantity[i] + "\t");
                if (rnd.Next(1, 4) == 1) Console.Write("Ammunition: Small \t");
                else if (rnd.Next(1, 4) == 2) Console.Write("Ammunition: Mid-S \t");
                else if (rnd.Next(1, 4) == 3) Console.Write("Ammunition: Mid-L \t");
                else Console.Write("Ammunition: Large \t");
                if (rnd.Next(1, 3) == 1) Console.Write("capacity: Small \t");
                else if (rnd.Next(1, 3) == 2) Console.Write("capacity: Mid \t");
                else Console.Write("capacity: Large \t");
                Console.Write("Range: " + rnd.Next(10, 30) + "\t");
                Console.Write("Size: " + rnd.Next(1,3) + "\t");
                Console.Write("Weight: " + rnd.Next(4,20) + "\t");
                if (rnd.Next(1, 10) == 1) Console.Write("quality:  True \t");
                else Console.Write("quality:  False \t");
                Console.Write("\n");
            }


                Console.ReadKey();
        }
    }
}
