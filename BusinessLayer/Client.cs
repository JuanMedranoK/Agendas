using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class Client
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string PhoneJob { get; set; }

        public string Direction { get; set; }
        
    }
}
