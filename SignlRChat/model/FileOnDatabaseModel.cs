using System.ComponentModel.DataAnnotations;

namespace SignlRChat.model
{
    public class FileOnDatabaseModel
    {

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please select a file.")]
        [Display(Name = "File")]
        public IFormFile File { get; set; }



    }
}
