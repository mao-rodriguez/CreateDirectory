using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CreateDirectory
{
    class Folder
    {
        public static bool CheckPath(string path)
        {
            char[] invalidPathChars = Path.GetInvalidFileNameChars();
            foreach (char c in path)
            {
                foreach (char invalidChar in invalidPathChars)
                {
                    bool wrongChar = c.Equals(invalidChar);
                    if (wrongChar)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
