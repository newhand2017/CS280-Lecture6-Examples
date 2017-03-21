using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class FireTypePokemon : Pokemon
    {
        public int FireTypePowerUpCandy { get; set; }

        public int FireTypePowerUpStarDust { get; set; }

        //-------------------------------------------------
        // 建構式
        //-------------------------------------------------
        public FireTypePokemon(
            string name,
            int nationNo,
            string[] type,
            float height,
            float weight,
            int fireTypePowerUpCandy,
            int fireTypePowerUpStarDust
        )
            : base(
            name,
            nationNo,
            type,
            height,
            weight
            )
        {
            this.FireTypePowerUpCandy = fireTypePowerUpCandy;
            this.FireTypePowerUpStarDust = fireTypePowerUpStarDust;
        }
    }
}