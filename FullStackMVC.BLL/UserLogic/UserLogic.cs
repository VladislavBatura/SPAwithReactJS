using FullStackMVC.DAL.Context;
using FullStackMVC.DAL.Entities;
using FullStackMVC.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackMVC.BLL.UserLogic
{
    public class UserLogic : Repository<User>
    {
        DataContext context;

        public UserLogic(DataContext context) : base(context)
        {
            this.context = context;
        }

        //public void RollingRetention()
        //{
            
        //}
    }
}
