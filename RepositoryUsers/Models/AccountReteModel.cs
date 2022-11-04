using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCloud.Repository.Models
{
    public class AccountReteModel
    {
        public string Matricola { get; set; }
        public string Account { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public bool NTAccount { get; set; }
        public string Dominio { get; set; }
        public string Email { get; set; }
    }
}
