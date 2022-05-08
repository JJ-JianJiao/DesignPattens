using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleAndMonster_LowLevel
{
    internal sealed class Monster
    {
        public String Name { get; set; }

        public Int32 Health { get; set; }

        public Monster(String name, Int32 Health) {
            this.Name = name;
            this.Health = Health;
        }
    }
}
