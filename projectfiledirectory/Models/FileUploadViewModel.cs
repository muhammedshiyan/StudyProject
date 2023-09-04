namespace projectfiledirectory.Models
{
    public class FileUploadViewModel
    {
        public List<FileOnFileSystem> FilesOnFileSystem { get; set; }
        public List<FileOnDatabaseModel> FilesOnDatabase { get; set; }
    }
}
