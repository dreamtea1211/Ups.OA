﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringNetDemo
{
    public class EFUserInfoDal:IUserInfoDal
    {
        public string Name
        {
            get;
            set;
        }

        public void Show()
        {
            Console.WriteLine("EFUserInfoDal----SpringNet实例的属性:" + Name);
        }
    }
}
