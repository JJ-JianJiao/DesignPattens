using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleAndMonster_DependencyInjection
{
    internal sealed class Role
    {
        private string _name;
        private Int32 _health;

        public Role(string name, Int32 health) {
            _name = name;
            _health = health;
        }

        public IAttackTypes CurrentWeapon { get; set; }

        public void Attack(Monster monster) {
            CurrentWeapon.AttackTarget(monster);
        }

    }
}
