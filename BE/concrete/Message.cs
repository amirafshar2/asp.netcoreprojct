using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.concrete
{
    public class Message
    {
        [Key]
        public int id { get; set; }
        public string  Sender{ get; set; }
        public string  Receiver{ get; set; }
        public string  Subject{ get; set; }
        public DateTime  Date{ get; set; }
        public bool Status { get; set; }
    }
}
