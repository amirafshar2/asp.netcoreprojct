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
            var q = GetById(t.id);
            _ıBLogDal.Delete(q);
        }

        public List<Blog> GetAll()
        {
            return _ıBLogDal.GetAll();
        }

        public List<Blog> GetAll(int id)
        {
            return _ıBLogDal.GetAll(x => x.id == id);
        }

        public Blog GetBayİd(int id)
        {
            return _ıBLogDal.GetById(id);
        }

        public List<Blog> GetBlogByCategoryWithWriter(int id)
        {
            return _ıBLogDal.GetBlogsByCategoryWithWriter(id);
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
                if (a <= 3)
                {
                    q.Add(item);
                    a++;
                }

            }
            return q;
        }

        public List<Blog> Last10BlogList()
        {
            var q =  _ıBLogDal.GetBlogsFromCategory();
            int a = 0;
            List<Blog> b = new List<Blog>();
            foreach (var item in q)
            {
                if (a<10)
                {
                    b.Add(item);
                }
            }
            return b;
        }

        public void Update(Blog t)
        {
            
            _ıBLogDal.Update(t);
        }

        public void Update(Blog t, int id)
        {
            var q = GetById(id);
            q.Title = t.Title;
            q.Status = t.Status;
            q.İmage = t.İmage;
            q.Categoryid = t.Categoryid;
            q.Content = t.Content;
            q.TompNailİmage = t.TompNailİmage;
            q.CreateDate = t.CreateDate;

            _ıBLogDal.Update(q);
        }

        public void İnsert(Blog t)
        {
            _ıBLogDal.İnsert(t);
        }
    }
}
