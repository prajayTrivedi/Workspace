using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrange
{
    class Search
    {
        string source= @"C:\Users\workspace\Downloads";
        string destination = @"C:\otherwork\TVseries\thevampirediariesS07\";
        int fileCount = 0;

        public void SetDestination(string path)
        {
            destination = destination +"\\" +path;
        }

        public int returnFileCount()
        {
            return fileCount;
        }

        public void searchLocation(TVSeries tvseries)
        {
            foreach (string serial in tvseries.tvseries)
            {
                SetDestination(serial);
                DirectoryInfo Dinfo = new DirectoryInfo(source);
                FileInfo []filesInDirectory = Dinfo.GetFiles("*" + serial + "*", SearchOption.AllDirectories);
                foreach (FileInfo foundFile in filesInDirectory)
                {
                    String path = foundFile.Name;
                    if (!foundFile.Extension.Equals(".exe") && !foundFile.Extension.Equals(".zip") && !foundFile.Extension.Equals(".txt"))
                    {
                        foundFile.MoveTo(destination + path);
                        fileCount += 1;
                        Console.WriteLine(foundFile.Name + "  moved to  " + destination);
                    }
                }


            }
        }
    }
}
