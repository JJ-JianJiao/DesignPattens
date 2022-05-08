using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleAndMonster_LowLevel
{
    internal sealed class Role
    {
        private Random random = new Random();

        public String WeaponTag { get; set; }

        public void Attack(Monster monster) {
            if (monster.Health == 0) {
                Console.WriteLine(monster.Name + " is dead!");
                return;
            }

            if("WoodSword" == this.WeaponTag)
            {
                monster.Health -= 20;
                if(monster.Health < 0)
                {
                    Console.WriteLine(monster.Name + " is dead!");
                }
                else
                {
                    Console.WriteLine("Attack the Monster" + monster.Name + "lose 20 HP");
                }
            }
            else if ("IronSword" == this.WeaponTag)
            {
                monster.Health -= 50;
                if (monster.Health < 0)
                {
                    Console.WriteLine(monster.Name + " is dead!");
                }
                else
                {
                    Console.WriteLine("Attack the Monster" + monster.Name + "lose 50 HP");
                }
            }
            else if ("MagicSword" == this.WeaponTag)
            {
                monster.Health -= 200;
                if (monster.Health < 0)
                {
                    Console.WriteLine(monster.Name + " is dead!");
                }
                else
                {
                    Console.WriteLine("Attack the Monster" + monster.Name + "lose 200 HP");
                }
            }
            else
            {
                Console.WriteLine("The charactor does not have any weapon, can not attack.");
            }
        }
    }
}
