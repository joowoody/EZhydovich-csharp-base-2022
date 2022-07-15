﻿using Weapons.Extensions;
using Weapons.Models;

namespace Weapons
{
    internal static class Program
    {
        public static void Main()
        {
            bool i;
            int option;
            var weapons = new Weapon[]
            {
                new Bow
                {
                    Name = "SuperBow",
                    DmgOfShot = 20,
                    Price = 90,
                    Range = 80
                },
                new Crossbow
                {
                    Name = "Scorpion",
                    DmgOfShot = 50,
                    Price = 200,
                    Range = 200
                },
                new Knife(5)
                {
                    Name = "CS Knife",
                    DmgOfShot = 40,
                    Price = 32
                },

                new Carbin
                {
                    Name = "M4A1",
                    DmgOfShot = 80,
                    Cage = 30,
                    Price = 342
                },
                new Pistol(friendlyname:"My little baby")
                {
                    Name = "Desert Eagle",
                    DmgOfShot = 80,
                    Cage = 7,
                    Price = 210

                },
                new Sword(140)
                {
                    Name = "Arthur's Sword",
                    DmgOfShot = 30,
                    Price = 800
                        
                }

            };
            
            var usp = new Pistol(friendlyname:"My Baby")
            {
                Cage = 12,
                DmgOfShot = 40,
                Price = 82,
                
            };
            usp.Holster();
            Console.WriteLine(usp._friendlyname);




            do
            {
                i = int.TryParse(Console.ReadLine(), out option);
            } while (i == false || option is > 2 or < 1);


            if (option == 1)
            {
                foreach (var weapon in weapons)
                {
                    Console.WriteLine($"Name of weapon: {weapon.Name}");
                }
            }
            else
            {
                foreach (var weapon in weapons)
                {
                    Console.WriteLine($"Price of {weapon.Name}: {weapon.Price}");
                }
            }

            var usp2 = usp.Copy();
            usp2.Name = "Interesting pistol";
            usp2.Price = 21;
            usp2.DmgOfShot = 74;
            
            Console.WriteLine($"New weapon is: {usp.GetType()}, name:  {usp2.Name}");
        }
    }
}  

