using BE.concrete;
using BLL.Abstract;
using DAL.Abstract;
using DAL.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concreate
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efcr;
        public CategoryManager()
        {
            efcr = new EfCategoryRepository();
        }
        public void İnsert(Category category)
        {
            efcr.İnsert(category);
        }
       
        public void Delete(Category category)
        {
            efcr.Delete(category);
        }
        public void Update(Category category)
        {
            efcr.Update(category);
        }
        public List<Category> GetAll()
        {
           return efcr.GetAll();
        }
        public Category GetById(int id)
        {
            return efcr.GetById(id);
        }
    }
}
