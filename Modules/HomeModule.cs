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
            // new user
            Get["/signup"] = _ => {
                return View["signup.cshtml"];
            };

            Post["/welcome/new"] = _ => {
                Customer newCustomer = new Customer(Request.Form["customer-name"], Request.Form["customer-photo"], Request.Form["customer-email"], Request.Form["customer-password"]);
                newCustomer.Save();
                return View["welcome_new.cshtml", newCustomer];
            };

            // returning user
            Get["/login"] = _ => {
                return View["login.cshtml"];
            };

            Post["/welcome/returning"] = _ => {
                Customer returningCustomer = Customer.CustomerLogin(Request.Form["customer-email"], Request.Form["customer-password"]);
                if (returningCustomer == null)
                {
                    return View["login_fail.cshtml"];
                }
                else
                {
                    return View["welcome_returning.cshtml", returningCustomer];
                }
            };

            // all users
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

            // dogs
            Get["/profile/{id}/dogs"] = parameters => {
                Dictionary<string, object> model = new Dictionary<string, object>{};
                List<Dog> AllDogs = Dog.GetAll();
                Customer SelectedCustomer = Customer.Find(parameters.id);
                model.Add("dogs", AllDogs);
                model.Add("customer", SelectedCustomer);
                return View["dogs.cshtml", model];
            };

            Get["/profile/{id}/dogs/{id}"] = parameters => {
                Dictionary<string, object> model = new Dictionary<string, object>();
                Dog newDog = Dog.Find(parameters.id);
                Customer SelectedCustomer = Customer.Find(parameters.id);
                model.Add("dog", newDog);
                model.Add("customer", SelectedCustomer);
                return View["dog.cshtml", model];
            };

        }
    }
}
