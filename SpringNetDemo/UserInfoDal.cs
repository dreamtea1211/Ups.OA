using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpringNetDemo
{
    public class UserInfoDal:IUserInfoDal
    {
        public UserInfoDal(string name)
        {
            Name = name;
        }
        public string Name
        {
            get;
            set;
        }

        public void Show()
        {
            Console.WriteLine("欢迎SpringNet实例,构造函数  " + Name);
        }
    }
}
