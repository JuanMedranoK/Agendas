using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public sealed class Repositorio
    {
        public List<Client> Cliente { get; set; } = new List<Client>();

        public static Repositorio Instance { get; } = new Repositorio();

        private Repositorio()
        {

        }
    }
}
