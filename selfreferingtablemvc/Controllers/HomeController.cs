using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using selfreferingtablemvc.Models;
using System.Diagnostics;
using System.Transactions;
using static System.Formats.Asn1.AsnWriter;

namespace selfreferingtablemvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public List<Employee> employees { get; private set; }

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            
          //  var scope = new TransactionScope();

            try
            {
                employees = _context.Employees.ToList();

                // Create instances of Employee
                var johnDoe = new Employee { FirstName = "John", LastName = "Doe" };
                var aliceSmith = new Employee { FirstName = "Alice", LastName = "Smith" };
                var bobJohnson = new Employee { FirstName = "Bob", LastName = "Johnson" };
                var johnDoe1 = new Employee { FirstName = "John2", LastName = "Doe2" };
                var aliceSmith1 = new Employee { FirstName = "Alice2", LastName = "Smith2" };
                var bobJohnson1 = new Employee { FirstName = "Bob2", LastName = "Johnson2" };



                // Set up the self-referencing relationship
                aliceSmith1.Manager = johnDoe;
                bobJohnson1.Manager = aliceSmith;

                // Add employees to the DbSet
                //   _context.Employees.AddRange(johnDoe1, aliceSmith1, bobJohnson1);

                //   string tableName = "Products";
                //   _context.Database.ExecuteSqlRaw($"TRUNCATE TABLE {tableName};");


                //   var result = _context.Database.FromSqlRaw("EXEC MyStoredProcedure @parameter1, @parameter2", parameter1Value, parameter2Value).ToList();


                //  var result = _context.Database.ExecuteSqlRaw("EXEC sp_productsall");
                //      var result = _context.Database.ExecuteSqlRaw("EXEC sp_productsall").ToString();
                var products1 = _context.Products.ToList();
                var products3 = _context.Products.FromSqlRaw("SELECT * FROM Products WHERE Price > {0}", 9).ToList();
                var products4 = _context.Products.FromSqlRaw("SELECT * FROM Products ").ToList();
                var products6 = _context.Products
                                    .Where(p => p.Price > 9)
                                                   .ToList();

                var products5 = _context.Products.FromSqlRaw("exec sp_productsall").ToList();


                var products =_context.Database.ExecuteSqlRaw("EXEC sp_productsall");


                // Save changes to the database
                _context.SaveChanges();

                // scope.Complete();
            }
            catch (Exception ex)
            {
             //   scope.Dispose();

            }
           





            return View(employees);
        }

        public IActionResult VIEWMANAGER()
        {
            var employeesWithManagerNames = _context.Employees
            .Include(e => e.Manager) // Include the Manager navigation property
            .Select(e => new EmployeeViewModel
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                ManagerName = e.Manager != null ? $"{e.Manager.FirstName} {e.Manager.LastName}" : "N/A"
            })
            .ToList();

            return View(employeesWithManagerNames);
        }

        public IActionResult SubordinatesOfManager(int managerId)
        {
                       
            var manager = _context.Employees
            .Include(e => e.Subordinates)
            .FirstOrDefault(e => e.EmployeeId == managerId);

            if (manager != null)
            {
                var subordinates = manager.Subordinates.ToList();
                return View("SubordinatesOfManager", subordinates);
            }

          //  return NotFound(); // Manager not found
        
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            //if (ModelState.IsValid)
            {
                // Save the employee to the database (use your DbContext here)
                _context.Employees.Add(employee);
           //     _context.Employees.AddRange(employee);
                _context.SaveChanges();
                return RedirectToAction("Index"); // Redirect to the employee list or another page
            }
            //return View(employee);
        }





        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}