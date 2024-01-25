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
	public class BlogeManager : IBlogeService
	{
		IBlogDAL _ıBLogDal;

		public BlogeManager(IBlogDAL ıBLogDal)
		{
			_ıBLogDal = ıBLogDal;
		}

		public void Delete(Blog t)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetAll()
		{
			return _ıBLogDal.GetAll();
		}

		public List<Blog> GetAll(int id)
		{
			return _ıBLogDal.GetAll(x => x.id == id);
		}

		public List<Blog> GetBlogsFromCategory()
		{
			return _ıBLogDal.GetBlogsFromCategory();
		}

		public Blog GetById(int id)
		{
			return _ıBLogDal.GetById(id);
		}

		public void Update(Blog t)
		{
			throw new NotImplementedException();
		}

		public void İnsert(Blog t)
		{
			throw new NotImplementedException();
		}

	
	}
}
