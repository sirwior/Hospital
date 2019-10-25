using System;
using Ninject.Modules;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.DAL.UnitOfWork.Interfaces;
using Hospital.DAL.UnitOfWork;

namespace Hospital.BLL.Infrastructure
{
    class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
