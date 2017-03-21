using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class FireTypePokemon : Pokemon
    {
        //-------------------------------------------------

        //-------------------------------------------------
        // 建構式
        //-------------------------------------------------
        public FireTypePokemon(
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
            // this.PowerUpCandy = 3;
            //  this.PowerUpStarDust = 3000;
        }
    }
}