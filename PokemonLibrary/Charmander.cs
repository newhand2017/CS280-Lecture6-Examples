using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Charmander : FireTypePokemon
    {
        //-------------------------------------------------
        // Initial Value
        //-------------------------------------------------
        public Charmander()
            : base(
            "小火龍",//name,
            4,//nationNo,
            new string[] { "Fire" },//type,
            0.61f,//height,
            8.5f//weight
            )
        {
            this.Hp = 190;
        }

        //-------------------------------------------------
        // Attack Lines
        //-------------------------------------------------
        public override void Attack(Pokemon other)
        {
            base.Attack(other);
            Console.WriteLine("火花");

            other.Hp -= 15;
            Console.WriteLine("{0}損失15HP, 剩下{1}", other.Name, other.Hp);
        }

        //-------------------------------------------------
    }
}