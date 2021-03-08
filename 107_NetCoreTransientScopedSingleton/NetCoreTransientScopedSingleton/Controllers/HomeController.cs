using Microsoft.AspNetCore.Mvc;
using NetCoreTransientScopedSingleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTransientScopedSingleton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransient transientService1;
        private readonly ITransient transientService2;
        private readonly ISingleton singletonService1;
        private readonly ISingleton singletonService2;
        private readonly IScoped scopedService1;
        private readonly IScoped scopedService2;

        public HomeController(ITransient transientService1,ITransient transientService2, ISingleton singletonService1, ISingleton singletonService2,IScoped scopedService1, IScoped scopedService2)
        {
            this.transientService1 = transientService1;
            this.transientService2 = transientService2;
            this.singletonService1 = singletonService1;
            this.singletonService2 = singletonService2;
            this.scopedService1 = scopedService1;
            this.scopedService2 = scopedService2;
        }

        public IActionResult Index()
        {
            //Transient
            ViewBag.TransientService1 = transientService1.GetOperation();
            ViewBag.TransientService2 = transientService2.GetOperation();

            //Singleton
            ViewBag.SingletonService1 = singletonService1.GetOperation();
            ViewBag.SingletonService2 = singletonService2.GetOperation();

            //Scoped
            ViewBag.ScopedService1 = scopedService1.GetOperation();
            ViewBag.ScopedService2 = scopedService2.GetOperation();
            return View();
        }
    }
}
