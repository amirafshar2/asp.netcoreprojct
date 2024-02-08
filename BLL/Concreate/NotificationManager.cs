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
	public class NotificationManager : INotificationService
	{
		INotificationDAL _ıNotificationDAL;

		public NotificationManager(INotificationDAL ıNotificationDAL)
		{
			_ıNotificationDAL = ıNotificationDAL;
		}

		public void Delete(Notification t)
		{
			throw new NotImplementedException();
		}

		public List<Notification> GetAll()
		{
			return _ıNotificationDAL.GetAll();
		}

        public List<Notification> GetAllTrue()
        {
			return _ıNotificationDAL.GetAll().Where(i => i.Status == true).ToList();
        }

        public Notification GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(Notification t)
		{
			throw new NotImplementedException();
		}

		public void İnsert(Notification t)
		{
			throw new NotImplementedException();
		}
	}
}
