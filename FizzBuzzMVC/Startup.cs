﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FizzBuzzMVC.Startup))]
namespace FizzBuzzMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
