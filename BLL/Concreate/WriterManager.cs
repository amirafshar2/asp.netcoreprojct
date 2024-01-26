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
    public class WriterManager : IWriterService
    {
        IWriterDAL _writerDAL;

		public WriterManager(IWriterDAL writerDAL)
		{
			_writerDAL = writerDAL;
		}

		public void İnsert(Writer t)
        {
            _writerDAL.İnsert(t);
        }
    }
}
