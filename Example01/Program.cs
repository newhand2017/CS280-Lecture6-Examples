using PokemonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Pokemon pokemon1 = new Bulbasaur();
            //pokemon1.Hp = 200;

            //Pokemon pokemon2 = new Ivysaur();
            //pokemon2.Hp = 185;

            //if (args.Length >= 2)
            // {
            //     Pokemon pokemon1 = PokemonFactory.Creat(args[0]);
            //     Pokemon pokemon2 = PokemonFactory.Creat(args[1]);
            //
            //     Console.WriteLine(pokemon1.PowerUpCandy[pokemon1.Name]);
            //     pokemon1.Attack(pokemon2);
            // }
            //  else
            // {
            //     Console.WriteLine("參數輸入錯誤");
            // }

            if (args.Length >= 2)
            {
                Gym gym = new Gym(args);
                gym.Fight();
            }
            else
            {
                Console.WriteLine("參數輸入錯誤");
            }
        }
    }
}