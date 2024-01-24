using BE.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
	public interface IBlogeService	
	{
		void İnsert(Blog t);
		void Delete(Blog t);
		void Update(Blog t);
		List<Blog> GetAll();
		Blog GetById(int id);
	}
}
