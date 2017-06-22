using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contact
    {
        public string Cod { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Detalle { get; set; }

        public string Num_movile { get; set; }
        public string Num_work { get; set; }
        public string Num_staff { get; set; }
        public string Num_other { get; set; }

        public string Email_work { get; set; }
        public string Email_home { get; set; }
        public string Email_other { get; set; }
    }
}
