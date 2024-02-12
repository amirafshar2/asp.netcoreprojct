using BE.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IMessageDAL : IGenericDAL<Message2>
    {
        List<Message2> MessageListBaySenderAndReciver(int id);
    }
}
