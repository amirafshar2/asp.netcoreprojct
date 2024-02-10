using BE.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IMessageService : IGenericService<Message2>
    {
        List<Message2> GetListBayWriter(int id);
    }
}
