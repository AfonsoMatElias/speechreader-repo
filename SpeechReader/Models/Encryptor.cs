using System;
using System.Text;

namespace SpeechReader
{
    /// <summary>
    /// Helper to Encrypt a string and also Decrypt it
    /// </summary>
    public class Encryptor
    {
        /// <summary>
        /// The encriptor function
        /// </summary>
        /// <param name="decrypted">the decrypted string</param>
        /// <returns> the encrypted string </returns>
        public static string Encrypt(string decrypted)
        {
            byte[] textbytes = null;
            try
            {
                textbytes = ASCIIEncoding.ASCII.GetBytes(decrypted);
            }
            catch
            {
                return decrypted;
            }
            return Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(Convert.ToBase64String(textbytes)));
        }

        /// <summary>
        /// The decryptor function
        /// </summary>
        /// <param name="encrypted">the encrypted string</param>
        /// <returns>the decrypted string </returns>
        public static string Decrypt(string encrypted)
        {
            byte[] textbytes = null;
            try
            {
                textbytes = Convert.FromBase64String(encrypted);
            }
            catch
            {
                return encrypted;
            }
            return ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(ASCIIEncoding.ASCII.GetString(textbytes)));
        }

    }
}
