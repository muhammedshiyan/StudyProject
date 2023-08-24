using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Xml.Linq;

namespace fileuploadcore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private string fullPath = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "UploadImages";
        private string fileExtension;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public FileUpload fileUpload { get; set; }


        public void OnGet()
        {
            ViewData["SuccessMessage"] = "uuuuuuuuu";
        }

        //private readonly ILogger<IndexModel> _logger;
        //private string fullPath = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "UploadImages";
        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}
        //[BindProperty]
        //public FileUpload fileUpload { get; set; }
        //public void OnGet()
        //{
        //    ViewData["SuccessMessage"] = "";
        //}






 //       public IActionResult OnPostUpload(FileUpload fileUpload)
 //       {
 //           //Creating upload folder
 //           if (!Directory.Exists(fullPath))
 //           {
 //               Directory.CreateDirectory(fullPath);
 //           }
 //           var formFile = fileUpload.FormFile;
 //           var filePath = Path.Combine(fullPath, formFile.FileName);

 //           using (var stream = System.IO.File.Create(filePath))
 //           {
 //               formFile.CopyToAsync(stream);
 //           }

 //           // Process uploaded files
 //           // Don't rely on or trust the FileName property without validation.

 //           // File upload to database
 //           //Get File Name
 //           var filename = Path.GetFileName(formFile.FileName);
 //           //Get file Extension
 //           var fileextension = Path.GetExtension(filename);
 //           // concatenating  File Name and File Extension
 //           var newfilename = String.Concat(Convert.ToString(Guid.NewGuid()), fileextension);

 //           var documentViewmodel = new DocumentViewmodel()
 //           {
 //               Id = 0,
 //               FileName = newfilename,
 //               FileType = fileExtension,
 //               Created = DateTime.Now,
 //               Modified = DateTime.Now
 //           };

 //           using (var target = new MemoryStream())
 //           {
 //               formFile.CopyTo(target);
 //               documentViewmodel.FileData = target.ToArray();
 //           }

 //           // use this documentViewmodel to save record in database

 ////           [FileName][nvarchar] (250) NOT NULL,
    
 ////       [FileType] [varchar] (100) NULL,
	////[FileData][varbinary] (max)NOT NULL,
            







 //           ViewData["SuccessMessage"] = formFile.FileName.ToString() + " files uploaded!!";
 //           return Page();
 //       }



        public async Task<IActionResult> OnPostUploadAsync(IFormFile formFile)
        {
            if (formFile != null && formFile.Length > 0)
            {
                // Process and save the uploaded image
                // Generate a unique filename, save the file, etc.
                string imagePath = "path_to_your_image_directory/";// + uniqueFileName;

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }

                // Return the image URL as JSON response
                return new JsonResult(new { imageUrl = imagePath });
            }

            return BadRequest("No file uploaded.");
        }

        public class FileUpload
        {
            [Required]
            [Display(Name = "File")]
            public IFormFile FormFile { get; set; }
            public string SuccessMessage { get; set; }
        }


        public class DocumentViewmodel
        {
            public int Id { get; set; }
            [MaxLength(250)]
            public string FileName { get; set; }
            [MaxLength(100)]
            public string FileType { get; set; }
            [MaxLength]
            public byte[] FileData { get; set; }
            public DateTime Created { get; set; }
            public DateTime Modified { get; set; }
        }








    }
}