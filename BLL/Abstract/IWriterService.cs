using BE.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IWriterService : IGenericService<Writer>
    {
       public List<Writer> GetWriterBayId(int id);
    }
}
