using System;
using System.IO;

namespace CreateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the directory to manipulate
            //string path = @"c:\testDir\secondTest";
            string path = Console.ReadLine();

            try
            {
                
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("The path already exists");
                    return;
                }

                if (Folder.CheckPath(path))
                {
                    string invalidCharacters = new string(Path.GetInvalidPathChars());
                    Console.WriteLine("Folder names cannot have any of next characters " + invalidCharacters);
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfuly at {0}.", Directory.GetCreationTime(path));

            }
            catch(Exception e)
            {
                Console.WriteLine("The process failed at {0}", e.ToString());
            }

            finally { }

        }
        
        //public bool CheckPath(string path)
        //{
        //    char[] invalidPathChars = Path.GetInvalidPathChars();
        //    foreach(char c in path)
        //    {
        //        foreach(char invalidChar in invalidPathChars)
        //        {
        //            bool wrongChar = c.Equals(invalidChar);
        //            if (wrongChar) 
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}
        
    }
}
