using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.DataAccess.Services
{
    public class DocumentService
    {
        public static byte[] GetDocumentAsBytes(string FileName)
        {
            using (FileStream fs = new(FileName, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = File.ReadAllBytes(FileName);
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                return bytes;
            }
        }
    }
}
