using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.concrete
{
    public class Blog
    {
        [Key]
        public int id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string TompNailİmage { get; set; }
        public string İmage {  get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public int Categoryid { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        
        public int Writerid { get; set; }
        public Writer Writer { get; set; }

    }   
}
