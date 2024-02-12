using BE.concrete;
using DAL.Abstract;
using DAL.Context;
using DAL.Repostory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFrameWork
{
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDAL
    {
        DB db = new DB();

        public Writer GetWriterBayEmail(string e)
        {
            return db.writers.Where(i => i.Mail == e).FirstOrDefault();
        }

        public void Updatew(int id, Writer w)
        {
            var q =db.writers.Where(i=>i.id == id).SingleOrDefault();
            if (q !=null)
            {
                q.Name= w.Name;
                q.Status= w.Status;
                q.About= w.About;
                q.İmage = w.İmage;
                q.Mail= w.Mail;
                q.Password=w.Password;
                db.SaveChanges();
            }
        }

    }
}
