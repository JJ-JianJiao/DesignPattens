using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleAndMonster_DependencyInjection
{
    internal class WoodSord : IAttackTypes
    {
        private Int32 damage = 20;

        public void AttackTarget(Monster monster)
        {
            monster.GetDamage(damage);
        }
    }

    internal class IronSword : IAttackTypes
    {
        private Int32 damage = 50;

        public void AttackTarget(Monster monster)
        {
            monster.GetDamage(damage);
        }
    }

    internal class MagicSword : IAttackTypes
    {
        private Int32 damage = 200;

        public void AttackTarget(Monster monster)
        {
            monster.GetDamage(damage);
        }
    }
}
