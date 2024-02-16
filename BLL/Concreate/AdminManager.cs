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
    public class AdminManager : IAdminService
    {
        IAdminDAL _admindal;

        public AdminManager(IAdminDAL admindal)
        {
            _admindal = admindal;
        }

        public void Delete(Admin t)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAll()
        {
            throw new NotImplementedException();
        }

        public Admin GetById(int id)
        {
            return _admindal.GetById(id);
        }

        public void Update(Admin t)
        {
            throw new NotImplementedException();
        }

        public void İnsert(Admin t)
        {
            throw new NotImplementedException();
        }
    }
}
