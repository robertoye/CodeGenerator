using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CodeGenerator
{
    public class FileHelper
    {
        public bool DirExists(string strDir)
        {
            bool result = false;

            return result;
        }

        public bool FileExists(string strDir,string strFileName)
        {
            bool result = false;

            return result;
        }

        public bool FileExistsAndReadOnly(string strDir, string strFileName)
        {
            bool result = false;

            return result;
        }

        public static string ReadTemplate(string strPath)
        {
            return File.ReadAllText(strPath);
        }

        public static void WriteCodeToFile(string strPath,string strContent)
        {
            File.WriteAllText(strPath,strContent);
        }
    }
}
