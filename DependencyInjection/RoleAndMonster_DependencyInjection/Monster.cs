using System;


namespace RoleAndMonster_DependencyInjection
{
    public class Monster
    {
        private string _name;
        private Int32 _health;
        private bool isDead;

        public Monster(string name, Int32 health) {
            this._name = name;
            this._health = health;
            isDead = false;
        }

        public void GetDamage(Int32 damage) {
            if (isDead)
            {
                Console.WriteLine("Monster" + _name + " is already dead!");
                return;
            }
            _health -= damage;
            if (_health < 0)
            {
                Console.WriteLine("Monster" + _name + " is beed killed!");
                isDead = true;
            }
            else {
                Console.WriteLine("Monster" + _name + " get " + damage.ToString() + " damage");
            }
        }
    }
}