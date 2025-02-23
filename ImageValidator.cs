using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace RMBackground 
{
    public static class ImageValidator
    {
        /// <summary>
        /// Vérifie si un fichier est une image JPG/PNG valide.
        /// </summary>
        public static bool IsValidImage(string filePath)
        {
            if (!File.Exists(filePath))
                return false;

            string ext = Path.GetExtension(filePath)?.ToLower();
            if (ext != ".jpg" && ext != ".jpeg" && ext != ".png")
                return false;

            if (!IsRealImage(filePath))
                return false;

            try
            {
                using (Image img = Image.FromFile(filePath)) { }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Vérifie la signature magique du fichier pour s'assurer que c'est bien une image.
        /// </summary>
        private static bool IsRealImage(string filePath)
        {
            byte[] jpgMagic = new byte[] { 0xFF, 0xD8, 0xFF };
            byte[] pngMagic = new byte[] { 0x89, 0x50, 0x4E, 0x47 };

            byte[] fileHeader = new byte[4];

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                fs.Read(fileHeader, 0, fileHeader.Length);
            }

            return fileHeader.Take(3).SequenceEqual(jpgMagic) || fileHeader.Take(4).SequenceEqual(pngMagic);
        }
    }
}
