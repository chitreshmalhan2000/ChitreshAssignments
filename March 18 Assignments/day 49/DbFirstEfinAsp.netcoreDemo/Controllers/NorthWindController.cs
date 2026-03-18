using DbFirstEfinAsp.netcoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DbFirstEfinAsp.netcoreDemo.Controllers
{
    public class NorthWindController : Controller
    {
        public IActionResult SpainCustomers()
        {
            NorthWindContext cnt = new NorthWindContext();

            var spainCustomers = cnt.Customers
                .Where(x => x.Country == "Spain")
                .Select(x => new SpainCustomerViewModel
                {
                    Cid = x.CustomerId,
                    Cname = x.ContactName,
                    Comname = x.CompanyName
                })
                .ToList();

            return View(spainCustomers);
        }
        public IActionResult searchCustomer(string contactname)
        {
            NorthWindContext cnt = new NorthWindContext();
            var searchcustomer = from customer in cnt.Customers
                                 where customer.ContactName == contactname
                                 select new Customer
                                 {
                                     ContactName = customer.ContactName,
                                     ContactTitle = customer.ContactTitle,
                                     CompanyName = customer.CompanyName

                                 };
            var searchcustomer2 = cnt.Customers.Where(x => x.
            ContactName == contactname)
                .Select(x => new Customer
                {
                    ContactName = x.ContactName,
                    ContactTitle = x.ContactTitle,
                    CompanyName = x.CompanyName
                });
            var query1 = searchcustomer.Single();// can also use searchcustomer2
            var query2 = searchcustomer2.Single();
            return View(query1);// or query2 can be used 

        }
        public ActionResult ProductsInCategory(String categoryname)
        {
            NorthwndContext cnt = new NorthwndContext();
            var productsinCategory = cnt.Products.
                                     Where(x => x.Category.CategoryName == categoryname).
                                        Select(x => new ProdCat
                                        {
                                            prodname = x.ProductName,
                                            catname = x.Category.CategoryName,
                                        }).ToList();
            return View(productsinCategory);
        }
        public ActionResult OrderRange(string range)
        {
            NorthWindContext cnt = new NorthWindContext();
            var range1=Convert.ToInt32(range);
            var custOrderCount=cnt.Customers.Where(x => x.Orders.Count > range1)
                .Select(x => new Customer
                {
                    CustomerId=x.CustomerId,
                    ContactName=x.ContactName,
              
                }).ToList();
            return View(custOrderCount);
        }

        public IActionResult CustomerOrderDetails(string id)
        {
            NorthWindContext cnt = new NorthWindContext();

            var orders = cnt.Orders
                .Where(o => o.CustomerId == id)
                .Select(o => new Order
                {
                    OrderId = o.OrderId,
                    OrderDate = o.OrderDate,
                    RequiredDate = o.RequiredDate,
                    ShippedDate = o.ShippedDate
                }).ToList();

            ViewBag.CustomerId = id;

            return View(orders);
        }
    }
}

