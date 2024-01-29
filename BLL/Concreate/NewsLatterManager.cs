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

		public void AddNewsLatter(NewsLatter n)
		{
			_ıNewsdal.İnsert(n);
		}
	}
}
