namespace projectfiledirectory.Controllers
{
    internal class FileOnFileSystemModel
    {
        public DateTime CreatedOn { get; set; }
        public string FileType { get; set; }
        public string Extension { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
    }
}