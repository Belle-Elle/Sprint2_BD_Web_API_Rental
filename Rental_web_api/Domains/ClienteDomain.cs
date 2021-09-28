using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental_web_api.Domains
{
    public class ClienteDomain
    {
        public int idCliente { get; set; }
        public string idnomeCliente { get; set; }
        public string sobrenomeCliente { get; set; }
        public string CNH { get; set; }

    }
}
