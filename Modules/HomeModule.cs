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

            Get["profile/index/{id}"] = parameters => {
                Customer SelectedCustomer = Customer.Find(parameters.id);
                return View["user_index.cshtml", SelectedCustomer];
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

            //trips

            Get["/profile/{id}/newtrip"] = parameters => {
                Dictionary<string, object> model = new Dictionary<string, object>();
                List<Dog> AllDogs = Dog.GetAll();
                Customer SelectedCustomer = Customer.Find(parameters.id);
                Driver SelectedDriver = Driver.Find(parameters.id);
                model.Add("dog", AllDogs);
                model.Add("customer", SelectedCustomer);
                model.Add("driver", SelectedDriver);
                return View["trip_form.cshtml", model];
            };

            Post["/profile/{id}/trip_confirm"] = parameters => {
                Dictionary<string, object> model = new Dictionary<string, object>();
                Customer SelectedCustomer = Customer.Find(parameters.id);
                Trip newTrip = new Trip(Request.Form["start-address"], Request.Form["stop-address"], Request.Form["trip-date"], Request.Form["miles"], Request.Form["date"], 3, Request.Form["trip-dog"], SelectedCustomer.GetId());
                newTrip.Save();
                Dog SelectedDog = Dog.Find(parameters.id);
                model.Add("customer", SelectedCustomer);
                model.Add("trip", newTrip);
                model.Add("dog", SelectedDog);
                return View["trip_confirm.cshtml", newTrip];
            };

            Get["/profile/{id}/trips"] = parameters => {
                Dictionary<string, object> model = new Dictionary<string, object>{};
                List<Trip> AllTrips = Trip.GetAll();
                Customer SelectedCustomer = Customer.Find(parameters.id);
                model.Add("trips", AllTrips);
                model.Add("customer", SelectedCustomer);
                return View["trips.cshtml", model];
            };

            Get["/profile/{id}/trips/{id}"] = parameters => {
                Dictionary<string, object> model = new Dictionary<string, object>();
                Trip newTrip = Trip.FindById(parameters.id);
                Customer SelectedCustomer = Customer.Find(parameters.id);
                Dog SelectedDog = Dog.Find(parameters.id);
                model.Add("trip", newTrip);
                model.Add("customer", SelectedCustomer);
                model.Add("dog", SelectedDog);
                return View["trip.cshtml", model];
            };

        }
    }
}
