using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Pokemon
    {
        //-------------------------------------------------
        //Reference https://pokemondb.net/
        //-------------------------------------------------

        public string Name { get; set; }

        public int NationalNo { get; set; }

        public string[] Type { get; set; }

        public float Height { get; set; }

        public float Weight { get; set; }

        //-------------------------------------------------
        // 建構式
        //-------------------------------------------------

        public Pokemon(
            string name,
            int nationNo,
            string[] type,
            float height,
            float weight
            )
        {
            this.Name = name;
            this.NationalNo = nationNo;
            this.Type = type;
            this.Height = height;
            this.Weight = weight;
        }

        //-------------------------------------------------
    }
}