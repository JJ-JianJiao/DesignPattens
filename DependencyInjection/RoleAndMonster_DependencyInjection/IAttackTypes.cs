using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleAndMonster_DependencyInjection
{
    internal interface IAttackTypes
    {
        void AttackTarget(Monster monster);
    }
}
