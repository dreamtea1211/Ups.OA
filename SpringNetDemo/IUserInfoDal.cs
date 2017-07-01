using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpringNetDemo
{
    public interface IUserInfoDal
    {
        void Show();

        string Name { get; set; }
    }
}
