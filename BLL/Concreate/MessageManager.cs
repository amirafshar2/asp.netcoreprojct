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
    public class MessageManager : IMessageService
    {
        IMessageDAL _dal;

        public MessageManager(IMessageDAL dal)
        {
            _dal = dal;
        }

        public void Delete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetAll()
        {
          return  _dal.GetAll();
        }

        public Message2 GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetListBayWriter(int id)
        {

            return _dal.MessageListBaySenderAndReciver(id);
        }

        public void Update(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void İnsert(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
