using Autofac;
using Busines.Abstract;
using Busines.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Module = Autofac.Module;

namespace Busines.DespendencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();

            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
        }
    }
}
