using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Charmeleon : Charmander
    {
        //-------------------------------------------------
        // Initial Value
        //-------------------------------------------------
        public Charmeleon()
        {
            this.Name = "火恐龍";
            this.NationalNo = 5;
            this.Height = 1.09f;
            this.Weight = 19.0f;
            this.Hp = 215;

            this.PowerUpCandy[this.Name] = 2;
            this.PowerUpStardust[this.Name] = 2000;
            this.EvolveCandy[this.Name] = 100;
        }

        //-------------------------------------------------
        // Attack Line
        //-------------------------------------------------
        public override void Attack(Pokemon other)
        {
            base.Attack(other);
            Console.WriteLine("噴射火焰");

            other.Hp -= 20;
            Console.WriteLine("{0}損失15HP, 剩下{1}", other.Name, other.Hp);
        }

        //-------------------------------------------------
    }
}