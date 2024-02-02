using BE.concrete;
using DAL.Abstract;
using DAL.Context;
using DAL.Repostory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFrameWork
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDAL
    {
        public List<Blog> GetBlogsFromCategory()
        {
            using (var c = new DB())
            {
                return c.blogs.Include(i => i.Category).ToList();
            }
        }
        public List<Blog> GetBlogsByCategoryWithWriter(int id)
        {
            using (var db = new DB())
            {
                return db.blogs.Include(i => i.Category).Where(i => i.Writerid == id).ToList();
            }
        }
    }
}
