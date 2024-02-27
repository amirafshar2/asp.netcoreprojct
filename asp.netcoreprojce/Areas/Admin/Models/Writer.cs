namespace asp.netcoreprojce.Areas.Admin.Models
{
   
    
    public class Writer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public IFormFile İmage { get; set; }
        public bool Status { get; set; }
    }
}
