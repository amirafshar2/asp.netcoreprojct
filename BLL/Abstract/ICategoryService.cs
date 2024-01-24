using BE.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface ICategoryService 
    {
        void İnsert(Category t);
        void Delete(Category t);
        void Update(Category t);
        List<Category> GetAll();
        Category GetById(int id);
    }
}
