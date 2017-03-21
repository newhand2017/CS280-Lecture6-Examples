using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class GrassTypePokemon : Pokemon
    {
        //-------------------------------------------------
        //
        //-------------------------------------------------

        //-------------------------------------------------
        // 建構式
        //-------------------------------------------------
        public GrassTypePokemon(
            string name,
            int nationNo,
            string[] type,
            float height,
            float weight
        )
            : base(
            name,
            nationNo,
            type,
            height,
            weight
            )
        {
            this.PowerUpCandy[this.Name] = 3;
            this.PowerUpStardust[this.Name] = 3000;
        }

        public override void Attack(Pokemon other)
        {
            base.Attack(other);
            Console.WriteLine("使用草系絕招");
        }

        //-------------------------------------------------
    }
}