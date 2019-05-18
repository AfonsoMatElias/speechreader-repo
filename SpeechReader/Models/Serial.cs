using System.IO;

namespace SpeechReader
{
    public class Serial
    {
        public bool ProductActive { get; private set; }
        public Serial()
        {
            //File.WriteAllBytes("", new byte[] { });
        }

        public string Generate()
        {
            return System.Guid.NewGuid().ToString();
        }

        public bool CheckProduct(string serial)
        {
            return true;
        }

    }
}
