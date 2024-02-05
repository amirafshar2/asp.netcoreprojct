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
	public class NewsLatterManager : INewsLatterService
	{
		INewsLatterDAL _ıNewsdal;

		public NewsLatterManager(INewsLatterDAL ıNewsdal)
		{
			_ıNewsdal = ıNewsdal;
		}

		

        public void Delete(NewsLatter t)
        {
            throw new NotImplementedException();
        }

        public List<NewsLatter> GetAll()
        {
            throw new NotImplementedException();
        }

        public NewsLatter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(NewsLatter t)
        {
            throw new NotImplementedException();
        }

        public void Update(NewsLatter t, int id)
        {
            throw new NotImplementedException();
        }

        public void İnsert(NewsLatter t)
        {
            _ıNewsdal.İnsert(t);
        }
    }
}
