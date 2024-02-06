using BE.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
	public interface IBlogeService	: IGenericService<Blog>
	{
		
		List<Blog> GetBlogsFromCategory();
		List<Blog> GetAll(int id);
		List<Blog> GetBlogByWriter(int id);
		List<Blog> GetLast3Blogs();
		List<Blog> GetBlogByCategoryWithWriter(int id);
		Blog GetBayİd(int id);
		List<Blog> Last10BlogList();
    }
}
