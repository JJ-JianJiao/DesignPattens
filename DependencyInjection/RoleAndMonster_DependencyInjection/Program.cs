using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleAndMonster_DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster monster1 = new Monster("Monster A", 50);
            Monster monster2 = new Monster("Monster B", 50);
            Monster monster3 = new Monster("Level Boss", 200);
            Monster monster4 = new Monster("Final Boss", 1000);

            Role role = new Role("JJ", 9999);

            role.CurrentWeapon = new WoodSord();
            role.Attack(monster1);
            role.Attack(monster1);
            role.Attack(monster1);
            role.Attack(monster1);

            role.CurrentWeapon = new IronSword();
            role.Attack(monster2);
            role.Attack(monster2);
            role.Attack(monster2);
            role.Attack(monster2);
            role.Attack(monster2);
            role.Attack(monster2);
            role.Attack(monster3);
            role.Attack(monster3);
            role.Attack(monster3);

            role.CurrentWeapon = new MagicSword();
            role.Attack(monster3);
            role.Attack(monster3);
            role.Attack(monster3);
            role.Attack(monster4);
            role.Attack(monster4);
            role.Attack(monster4);
            role.Attack(monster4);
            role.Attack(monster4);
            role.Attack(monster4);

            Console.ReadLine();
        }
    }
}
