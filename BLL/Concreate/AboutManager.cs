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
    public class AboutManager : IAboutService
    {
        IAboutDAL _ıAboutDal;

        public AboutManager(IAboutDAL ıAboutDal)
        {
            _ıAboutDal = ıAboutDal;
        }

        public void Delete(About t)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAll()
        {
            return _ıAboutDal.GetAll();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(About t)
        {
            throw new NotImplementedException();
        }

        public void Update(About t, int id)
        {
            throw new NotImplementedException();
        }

        public void İnsert(About t)
        {
            throw new NotImplementedException();
        }
    }
}
