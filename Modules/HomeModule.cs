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

            Post["/welcome/new"] = _ => {
                Customer newCustomer = new Customer(Request.Form["customer-name"], Request.Form["customer-photo"], Request.Form["customer-email"], Request.Form["customer-password"]);
                newCustomer.Save();
                return View["welcome_new.cshtml", newCustomer];
            };

            Get["/login"] = _ => {
                return View["login.cshtml"];
            };
            //
            Post["/welcome/returning"] = parameters => {
                Dictionary<string, object> model = new Dictionary<string, object>();
                Customer SelectedCustomer = Customer.Find(parameters.id);
                Customer.CustomerLogin(Request.Form["customer-email"], Request.Form["customer-password"]);
                model.Add("customers", SelectedCustomer);
                return View["welcome_returning.cshtml", model];
            };

            Get["/ourdogs"] = _ => {
                List<Dog> AllDogs = Dog.GetAll();
                return View["dogs.cshtml", AllDogs];
            };

            Get["/profile/{id}"] = parameters => {
                Customer SelectedCustomer = Customer.Find(parameters.id);
                return View["profile.cshtml", SelectedCustomer];
            };

            Get["/profile/edit/{id}"] = parameters => {
                Customer SelectedCustomer = Customer.Find(parameters.id);
                return View["edit_profile.cshtml", SelectedCustomer];
            };

            Patch["/profile/update/{id}"] = parameters => {
                Customer SelectedCustomer = Customer.Find(parameters.id);
                SelectedCustomer.Update(Request.Form["update-name"], Request.Form["update-photo"]);
                return View["profile.cshtml", SelectedCustomer];
            };
        }
    }
}
