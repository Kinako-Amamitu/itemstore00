using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemShop
{
    internal class Have
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Many { get; set; }

        public Have(int id, string name, int many)
        {
            this.Id = id;
            this.Name = name;
            this.Many = many;
        }
    }
}
