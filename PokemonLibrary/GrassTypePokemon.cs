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

        public int GrassTypePowerUpCandy { get; set; }

        public int GrassTypePowerUpStarDust { get; set; }

        //-------------------------------------------------
        // 建構式
        //-------------------------------------------------
        public GrassTypePokemon(
            string name,
            int nationNo,
            string[] type,
            float height,
            float weight,
            int grassTypePowerUpCandy,
            int grassTypePowerUpStarDust
        )
            : base(
            name,
            nationNo,
            type,
            height,
            weight
            )
        {
            this.GrassTypePowerUpCandy = grassTypePowerUpCandy;
            this.GrassTypePowerUpStarDust = grassTypePowerUpStarDust;
        }

        //-------------------------------------------------
    }
}