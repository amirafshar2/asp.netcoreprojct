using BE.concrete;
using BLL.Abstract;
using DAL.Abstract;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concreate
{
    public class BlogeManager : IBlogeService
    {
        IBlogDAL _ıBLogDal;

        public BlogeManager(IBlogDAL ıBLogDal)
        {
            _ıBLogDal = ıBLogDal;
        }

        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            return _ıBLogDal.GetAll();
        }

        public List<Blog> GetAll(int id)
        {
            return _ıBLogDal.GetAll(x => x.id == id);
        }

        public List<Blog> GetBlogByWriter(int id)
        {
            List<Blog> q = new List<Blog>();
            int a = 0;
            foreach (var item in _ıBLogDal.GetAll(i => i.Writerid == id))
            {
                if (a <= 2)
                {
                    q.Add(item);
                    a++;
                }
            }
            return q;
        }

        public List<Blog> GetBlogsFromCategory()
        {
            return _ıBLogDal.GetBlogsFromCategory();
        }

        public Blog GetById(int id)
        {
            return _ıBLogDal.GetById(id);
        }

        public List<Blog> GetLast3Blogs()
        {
            List<Blog> q = new List<Blog>();
            int a = 0;
            foreach (var item in _ıBLogDal.GetAll())
            {
                if (a <=2)
                {
                    q.Add(item);
                    a++;
                }
                
            }
            return q;
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void İnsert(Blog t)
        {
            _ıBLogDal.İnsert(t);
        }
    }
}
