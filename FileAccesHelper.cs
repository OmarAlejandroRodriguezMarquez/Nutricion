using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    public class FileAccesHelper
    {
        public static string GetLocationFile(string filename)
        {
            return System.IO.Path.Combine(FileSystem.AppDataDirectory,filename);
        }
    }
}
