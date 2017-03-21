using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    //-------------------------------------------------
    // abstract : 抽象的. 禁止New
    //-------------------------------------------------

    public abstract class Pokemon
    {
        //-------------------------------------------------
        //Reference https://pokemondb.net/
        //-------------------------------------------------

        public string Name { get; set; }

        public int NationalNo { get; set; }

        public string[] Type { get; set; }

        public float Height { get; set; }

        public float Weight { get; set; }

        public Dictionary<string, int> PowerUpCandy { get; set; }

        public Dictionary<string, int> PowerUpStardust { get; set; }

        public Dictionary<string, int> EvolveCandy { get; set; }

        public int Hp { get; set; }

        public int Cp { get; set; }

        protected int Iv { get; set; }

        public Pokemon()
        {
        }

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

            this.PowerUpCandy = new Dictionary<string, int>();
            this.PowerUpStardust = new Dictionary<string, int>();
            this.EvolveCandy = new Dictionary<string, int>();
        }

        public virtual void Attack(Pokemon other)
        {
            Console.WriteLine("{0}攻擊{1}了", this.Name, other.Name);
        }

        //-------------------------------------------------
    }
}