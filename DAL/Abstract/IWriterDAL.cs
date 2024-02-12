using BE.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public  interface IWriterDAL:IGenericDAL<Writer>
    {
        void Updatew(int id , Writer w);
        Writer GetWriterBayEmail(string e);
    }
}
