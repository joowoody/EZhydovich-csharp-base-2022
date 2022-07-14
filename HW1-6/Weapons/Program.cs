using Weapons.Models;

namespace Weapons
{
    internal class Program
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
                new Pistol
                {
                    Name = "Desert Eagle",
                    DmgOfShot = 80,
                    Cage = 7,
                    Price = 210
                }

            };
           
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
                    Console.WriteLine(weapon.Price);
                }
            }
        }

    }


}  

