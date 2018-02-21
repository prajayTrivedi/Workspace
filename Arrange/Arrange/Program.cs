using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Arrange
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //loading the list of tvseries..
                TVSeries tvSeries = new TVSeries();
                Search searchFiles = new Search();
                searchFiles.searchLocation(tvSeries);
                Console.WriteLine( "All files moved" );
                Console.WriteLine("total files moved is"+ searchFiles.returnFileCount());
            }
            catch (Exception e)
            {
                Console.WriteLine("something went worng" + e.StackTrace);
            }
        }
    }
}
