using BE.concrete;
using DAL.Abstract;
using DAL.Context;
using DAL.Repostory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFrameWork
{
    public class EfMessageRepository : GenericRepository<Message2>, IMessageDAL
    {
        DB db = new DB();
        public List<Message2> MessageListBaySenderAndReciver(int id)
        {
            return db.messages2.Include(i=>i.SenderUser).Include(l=>l.ReceiverUser).Where(b=>b.Receiverid==id).ToList();
        }
    }
}
