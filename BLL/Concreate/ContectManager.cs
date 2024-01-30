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

		public void Create(Contact c)
		{
			_ıContectDal.İnsert(c);
		}
	}
}
