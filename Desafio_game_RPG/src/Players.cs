using Desafio_game_RPG;
namespace Desafio_game_RPG.src
{
    public class Players
    {
        public int at;
        public string spl;
        public Players(){

        }
        public Players(string Name, int Lvl, string HeroClass, int HP, int Mana, int Hit, string Attack){
            this.Name = Name;
            this.Lvl = Lvl;
            this.HeroClass = HeroClass;
            this.HP = HP;
            this.Mana = Mana;
            this.Hit = Hit;
            this.Attack = Attack;
        }
        public string Name;
        public int Lvl;
        public string HeroClass;
        public int HP;
        public int Mana;
        public int Hit;
        public string Attack;

        public override string ToString()
        {
            return this.Name + " " + this.Lvl;
        }

        public string PAttack(int a){
            at = a;           
            return this.Name + " Attacked with " + this.Attack + " causing " + a + " damage.";
        }
        public string BAttack(int a, string psl){
            at = a;
            spl = psl;
            return this.Name + " Attacked " + spl + " with " + this.Attack + " causing " + a + " damage.";
        }

    }
}