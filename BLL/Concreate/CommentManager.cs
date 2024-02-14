using BE.concrete;
using BLL.Abstract;
using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concreate
{
	public class CommentManager : ICommentServis
	{
		ICommentDAL _ıCommentDal;

		public CommentManager(ICommentDAL ıCommentDal)
		{
			_ıCommentDal = ıCommentDal;
		}

        public void Delete(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll(int id)
		{
			return _ıCommentDal.GetAll(i=>i.Blogid == id).ToList();
		}

        public List<Comment> GetAll()
        {
            return _ıCommentDal.GetAll();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment t)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment t, int id)
        {
            throw new NotImplementedException();
        }

        public void İnsert(Comment t)
		{
			_ıCommentDal.İnsert(t);
		}
	}
}
