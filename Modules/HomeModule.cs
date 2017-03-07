using System.Collections.Generic;
using Nancy;
using Nancy.ViewEngines.Razor;

namespace Cabrador
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>{
                return View["index.cshtml"];
            };

            Get["/signup"] = _ => {
                return View["signup.cshtml"];
            };

            Post["/welcome/new"] = parameters => {
                Customer newCustomer = new Customer(Request.Form["customer-name"], Request.Form["customer-photo"], Request.Form["customer-email"], Request.Form["customer-password"]);
                return View["welcome_new.cshtml"];
            };

            // Get["/login"] = _ => {
            //     return View["login.cshtml"];
            // };
            //
            // Post["/welcome/returning"] = _ => {
            //     return View["welcome_returning.cshtml"];
            // };
        }
    }
}
