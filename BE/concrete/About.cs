using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.concrete
{
   public class About
    {
        [Key]
        public int id { get; set; }
       
        public string Name { get; set; }
       
        public string Details1 { get; set; }
        public string Detaila2 { get; set; }
        public string İmage1 { get; set; }
        public string İmage2 { get; set; }
        public string MapLoc { get; set; }
        public bool Status { get; set; }

    }
}
