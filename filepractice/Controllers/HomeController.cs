using filepractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Reflection;

namespace filepractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string? folderPath;
        private object folderName;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!Directory.Exists(@"C:\temp\one"))
            {
                // Create the new folder
                Directory.CreateDirectory(@"C:\temp\one");
                               
            }


              string directoryPath = @"C:\temp\"; // Replace with the path to your directory
        //    string directoryPath = @"C:";

            // Get a list of folder names in the directory
            var folderNames = Directory.GetDirectories(directoryPath)
                                       .Select(Path.GetFileName)
                                       .ToList();

            var model = new folderlistmodel
            {
                FolderNames = folderNames
            };

            ViewBag.message = directoryPath;

            return View(model);
        }


        public IActionResult ViewFolder(string folderName)
        {

            try
            {  //  string directoryPath = Path.Combine(@"C:\temp", folderName); // Replace with the path to your directory

                string directoryPath = folderName;
                // Get a list of file names in the selected folder
                var fileNames = Directory.GetFiles(directoryPath)
                                        .Select(Path.GetFileName)
                                        .ToList();
                ViewBag.l = "\\";
                ViewBag.message = directoryPath;

                if (fileNames.Any())
                {



                }
                else
                {

                    ViewBag.message = directoryPath;
                    string newdirectoryPath = directoryPath; // Replace with the path to your directory

                    // Get a list of folder names in the directory
                    var folderNames = Directory.GetDirectories(newdirectoryPath)
                                               .Select(Path.GetFileName)
                                               .ToList();

                    var model = new folderlistmodel
                    {
                        FolderNames = folderNames
                    };

                    return View(model);



                }


                return View(fileNames);
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);
                var model = "empty";
                return View(model);
            }
            finally
            {
               
            }
          
        }


        public IActionResult ViewFoldernew(string folderName)
        {
            string directoryPath = Path.Combine(@"C:\temp", folderName); // Replace with the path to your directory

            // Get a list of file names in the selected folder
            var fileNames = Directory.GetFiles(directoryPath)
                                    .Select(Path.GetFileName)
                                    .ToList();



            if (fileNames.Any())
            {



            }
            else
            {
                ViewBag.l="\\";
                ViewBag.message = directoryPath;
                string newdirectoryPath = directoryPath; // Replace with the path to your directory

                // Get a list of folder names in the directory
                var folderNames = Directory.GetDirectories(newdirectoryPath)
                                           .Select(Path.GetFileName)
                                           .ToList();

                var model = new folderlistmodel
                {
                    FolderNames = folderNames
                };

                return View(model);



            }


            return View(fileNames);
        }



        public IActionResult addfolder()
        {
            return View();
        }



        [HttpPost]
       
        public IActionResult Create(string folderName,string newfolderName)
        {
             // Specify the root directory
             // Specify the name of the folder to delete

            

            try
            {
                //  string rootDirectory = @"C:\temp";
                // string rootDirectory = param1;
                 string rootDirectory = folderName;


                string folderPath = Path.Combine(rootDirectory, newfolderName);




                // Check if the folder exists before attempting to delete
                if (!Directory.Exists(folderPath))
                {
                    // Delete the folder and its contents
                    Directory.CreateDirectory(folderPath);
                    ViewBag.Message = $"Folder '{folderName}' created successfully in the root directory.";
                }

                else
                {
                    ViewBag.ErrorMessage = $"Folder '{folderName}' already  exist.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"Error: {ex.Message}";
            }






            return View();
        }

        [HttpPost]
        public IActionResult Delete(string fileName)
        {
            string folderPath;
            string folderName;


            if (!Directory.Exists(fileName))
            {
                string rootDirectory = @"C:\temp"; // Specify the root directory
                 folderName = fileName;  // Specify the name of the folder to delete

                 folderPath = Path.Combine(rootDirectory, folderName);

            }
            else
            {
                 folderPath = fileName;
                string [] myArray =folderPath.Split('\\');
                string lastItem = myArray[myArray.Length - 1];

                 folderName = lastItem;
            }


            try
            {
                // Check if the folder exists before attempting to delete
                if (Directory.Exists(folderPath))
                {
                    // Delete the folder and its contents
                    Directory.Delete(folderPath, true);
                    ViewBag.Message = $"Folder '{folderName}' has been deleted.";
                }
                else
                {
                    ViewBag.ErrorMessage = $"Folder '{folderName}' does not exist.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"Error: {ex.Message}";
            }

            return RedirectToAction("Index");
           
        }
    
        public IActionResult Check()
        {
            return View();
        }
        
        public IActionResult Move()
        {
            return View();
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