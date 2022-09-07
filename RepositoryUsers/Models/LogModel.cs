using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCloud.Repository.Models
{
    public class LogModel
    {
        public int Id { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }
    }
}
