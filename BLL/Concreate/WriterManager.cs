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

        public void Delete(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetAll()
        {
            return _writerDAL.GetAll();
        }

        public Writer GetById(int id)
        {
            return _writerDAL.GetById(id);
        }

        public Writer GetWriterBayEmail(string e)
        {
            return _writerDAL.GetWriterBayEmail(e);
        }

        public List<Writer> GetWriterBayId(int id)
		{
			return _writerDAL.GetAll().Where(i=>i.id == id).ToList();
		}

		public void Update(Writer t)
        {
            _writerDAL.Update(t);
        }

      

        public void Updatew(int id, Writer w)
        {
            _writerDAL.Updatew(id, w);
        }

        public void İnsert(Writer t)
        {
            _writerDAL.İnsert(t);
        }
    }
}
