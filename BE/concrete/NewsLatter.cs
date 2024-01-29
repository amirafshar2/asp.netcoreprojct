using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.concrete
{
	public class NewsLatter 
	{

		[Key]
		public int id { get; set; }
        public string Mail { get; set; }
        public bool Status { get; set; }

    }
}
