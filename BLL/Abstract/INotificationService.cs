﻿using BE.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
	public interface INotificationService : IGenericService<Notification>
	{
        public List<Notification> GetAllTrue();
    }
}
