using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrnoMvc1.Business.Services;
using Ninject.Modules;

namespace BrnoMvc1.Web.App_Start
{
    public class DefaultNinjectModule : NinjectModule
    {
        public override void Load()
        {
            if (HttpContext.Current.IsDebuggingEnabled)
            {
                this.Bind<IEmailService>().To<Business.Services.EmptyEmailService>();
            }
            else
            {
                this.Bind<IEmailService>().To<Business.Services.EmailService>();
            }
        }


    }
}