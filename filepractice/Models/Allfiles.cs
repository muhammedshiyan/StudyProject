using System.Collections.Generic;
using System.IO;
namespace filepractice.Models
{
    public class Allfiles
    {
        public List<string> FileNames { get; set; }

        public Allfiles(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                FileNames = new List<string>(Directory.GetFiles(folderPath));
            }
            else
            {
                FileNames = new List<string>();
            }
        }
    }
}
