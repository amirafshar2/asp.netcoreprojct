using BE.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IGenericDAL <T> where T : class
    {
        void İnsert(T t);
        void Delete(T t);   
        void Update(T t);
        List<T> GetAll();
        T GetById(int id);

    }
}
