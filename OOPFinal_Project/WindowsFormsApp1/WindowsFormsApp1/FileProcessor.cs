using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System;
using System.IO;

namespace WindowsFormsApp1
{
    class FileProcessor
    {
        [SqlFunction()]
        public static SqlBytes GetBytesFromFile(string sFilePath)
        {
            System.IO.FileStream fs = System.IO.File.Open(sFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            long lngLen = fs.Length;
            byte[] abytBuffer = new byte[(int)lngLen - 1];
            fs.Read(abytBuffer, 0, (int)lngLen - 1);
            fs.Close();
            SqlBytes b = new SqlBytes(abytBuffer);
            return b;
        }

    }
}
