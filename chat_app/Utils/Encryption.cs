using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace chat_app.Utils
{
    public class Encryption
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(Encryption).Name);

        public static string CreateMD5(string strInput)
        {
            if (string.IsNullOrEmpty(strInput))
            {
                throw new ArgumentNullException("Input CreateMD5");
            }

            strInput = strInput + "@Vinam@123";
            // Use input string to calculate MD5 hash
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(strInput);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder strHex = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    strHex.Append(hashBytes[i].ToString("X2"));
                }
                return strHex.ToString();
            }
        }
    }
}
