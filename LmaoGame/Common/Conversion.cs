using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmaoGame.Common
{
    class Conversion
    {
        public static Image ByteArrayToImage(byte[] imageByteArray)
        {
            try
            {
                MemoryStream ms = new MemoryStream(imageByteArray, 0, imageByteArray.Length);
                ms.Write(imageByteArray, 0, imageByteArray.Length);
                return Image.FromStream(ms, true);
            }
            catch
            {
                return null;
            }

        }
    }
}
