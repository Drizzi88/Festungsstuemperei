using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFortress.Models
{
    public class Dweller
    {
        public string Name { get; private set; } = "Unnamed";
        public Job Designation { get; set; }
    }
}