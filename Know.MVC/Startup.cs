﻿using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//[assembly: OwinStartupAttribute(typeof(Know.MVC.Startup))]
namespace Know.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            //ConfigureAuth(app);
        }
    }
}