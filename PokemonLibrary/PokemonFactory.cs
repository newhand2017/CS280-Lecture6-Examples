using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class PokemonFactory
    {
        public static Pokemon Creat(string name)
        {
            switch (name)
            {
                case "妙蛙種子":
                    return new Bulbasaur();

                case "妙蛙草":
                    return new Ivysaur();

                case "小火龍":
                    return new Charmander();

                case "火恐龍":
                    return new Charmeleon();

                default:
                    return new Bulbasaur();
            }
        }
    }
}