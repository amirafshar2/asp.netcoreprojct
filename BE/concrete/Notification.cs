using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.concrete
{
	public class Notification
	{
		[Key]
        public int id { get; set; }
        public string Type { get; set; }
		public string TypeSymbol { get; set; }
        public string  Details { get; set; }
        public DateTime Date { get; set; }
        public bool  Status { get; set; }
        public  string SymbolColor { get; set; }    

    }
}
