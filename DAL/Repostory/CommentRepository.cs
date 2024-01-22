using DAL.Abstract;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repostory
{
    public class CommentRepository<T> : IGenericDAL<T> where T : class
    {
        public void Delete(T t)
        {
            using var a = new DB();
            a.Remove(t);
            a.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var a = new DB();
            return a.Set<T>().ToList();

        }

        public T GetById(int id)
        {
            using var a = new DB();
            return a.Set<T>().Find(id);
        }

        public void Update(T t)
        {
            using var a = new DB();
            a.Update(t);
            a.SaveChanges();
        }

        public void İnsert(T t)
        {
            using var a = new DB();
            a.Add(t);
            a.SaveChanges();
        }
    }
}
