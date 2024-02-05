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
        ICategoryDAL _categoryDal;
        public CategoryManager(ICategoryDAL categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void İnsert(Category category)
        {
            _categoryDal.İnsert(category);
        }
       
        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
        public List<Category> GetAll()
        {
           return _categoryDal.GetAll();
        }
        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void Update(Category t, int id)
        {
            throw new NotImplementedException();
        }
    }
}
