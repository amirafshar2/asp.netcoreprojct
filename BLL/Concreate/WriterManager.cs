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
        IWriterDAL dal;

        public WriterManager(IWriterDAL dal)
        {
            this.dal = dal;
        }

        public void İnsert(Writer t)
        {
            dal.İnsert(t);
        }
    }
}
