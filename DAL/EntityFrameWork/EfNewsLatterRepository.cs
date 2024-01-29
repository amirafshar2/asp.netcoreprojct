using BE.concrete;
using DAL.Abstract;
using DAL.Repostory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFrameWork
{
	public class EfNewsLatterRepository : GenericRepository<NewsLatter>, INewsLatterDAL
	{
	}
}
