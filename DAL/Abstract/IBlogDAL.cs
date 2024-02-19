using BE.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IBlogDAL : IGenericDAL<Blog>
    {
        List<Blog> GetBlogsFromCategory();
        List<Blog> GetBlogsFromCategory(int catid);
        public List<Blog> GetBlogsByCategoryWithWriter(int id);
    }
}
