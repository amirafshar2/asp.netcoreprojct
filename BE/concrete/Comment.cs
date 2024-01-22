using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.concrete
{
    public class Comment
    {
        [Key]
        public int id { get; set; }
        public string UserName   { get; set; }
        public string Title { get; set; }
        public string Content {  get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

    }
}
