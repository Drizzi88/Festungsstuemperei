using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFortress.Models
{
    public class Fortress
    {
        public string Name { get; private set; }

        public void SetFortressName(string name)
        { Name = name; }
    }
}