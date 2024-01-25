using BE.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
	public interface ICommentServis
	{
		void İnsert(Comment t);
		//void Delete(Comment t);
		//void Update(Comment t);
		List<Comment> GetAll(int id);
		//Comment GetById(int id);
	}
}
