using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRC_Code_Designer.src.Core.Project
{
    public class Interface : Entity
    {
        public string Name { get; set; }

        public Interface(string name)
        {
            Name = name;
        }
    }
}
