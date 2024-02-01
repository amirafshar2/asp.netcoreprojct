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
	public class ContectManager : IContectService
	{
		IContactDAL _ıContectDal;

		public ContectManager(IContactDAL ıContectDal)
		{
			_ıContectDal = ıContectDal;
		}

	

        public void Delete(Contact t)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact t)
        {
            throw new NotImplementedException();
        }

        public void İnsert(Contact t)
        {
            _ıContectDal.İnsert(t);
        }
    }
}
