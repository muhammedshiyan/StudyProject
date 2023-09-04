using Microsoft.AspNetCore.Mvc;
using SignlRChat.Data;
using SignlRChat.model;

namespace SignlRChat.controller
{

        public class FileUploadController : Controller
        {
            private readonly SignlRChatContext _dbContext; // Inject your DbContext here
            private readonly IWebHostEnvironment _webHostEnvironment; // Inject the hosting environment

            public FileUploadController(SignlRChatContext dbContext, IWebHostEnvironment webHostEnvironment)
            {
                _dbContext = dbContext;
                _webHostEnvironment = webHostEnvironment;
            }

            [HttpGet]
            public IActionResult FileUpload()
            {
                return View();
            }

            [HttpPost("actionupload")]
            public IActionResult actionupload(FileOnDatabaseModel model)
            {
                if (!ModelState.IsValid)
                {
                    return View("FileUpload", model);
                }

                using (var transaction = _dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        // Upload and save the file to a specific location
                        var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.File.FileName;
                        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            model.File.CopyTo(fileStream);
                        }

                        // Perform your database operations within the transaction
                        var entity = new ApplicationUserEntityConfiguration
                        {
                    //........       Description = model.Description,
                        //    FilePath = filePath, // Save the file path in the database
                                                 // other properties
                        };
                 //.....       _dbContext.YourEntities.Add(entity);
                        _dbContext.SaveChanges();

                        // If everything is successful, commit the transaction
                        transaction.Commit();

                        // Redirect to a success page or return a view
                        return RedirectToAction("UploadSuccess");
                    }
                    catch (Exception ex)
                    {
                        // If an error occurs, roll back the transaction
                        transaction.Rollback();

                        // Optionally, log the exception or handle it in your application
                        Console.WriteLine("Transaction rolled back: " + ex.Message);

                        ModelState.AddModelError("", "An error occurred while processing the request.");
                        return View("FileUpload", model);
                    }
                }


            }


            public IActionResult UploadSuccess()
            {
                return View();
            }



        }
    }
      
