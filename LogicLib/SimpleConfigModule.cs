using DALLib;
using Ninject.Modules;
using StudentLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLib
{
    public class SimpleConfigModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<IRepository<Student>>().To<EntityFrameworkRepository<Student>>().InSingletonScope();
            Bind<IRepository<Student>>().To<DapperRepository<Student>>().InSingletonScope();
        }
    }
}
