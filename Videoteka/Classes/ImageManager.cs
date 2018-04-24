using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Resources;

namespace Videoteka {
    public static class ImageManager {

        private static Image defaultPoster = null;
        private static string defaultPosterResourceName = "Videoteka.Resources.no_poster.jpg";

        public static Image GetDefaultPoster() {
            if (defaultPoster != null) {
                return defaultPoster;
            }

            try {
                return Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(defaultPosterResourceName));
            }
            catch {
                return null;
            }
        }

        public static Image FormatPoster(byte[] bytes, int width, int height) {
            return bytes == null ? GetDefaultPoster() : ResizeImage(BytesToImage(bytes), width, height);
        }

        public static byte[] ImageToBytes(Image img) {
            using (var ms = new MemoryStream()) {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Image BytesToImage(byte[] bytes) {
            return Image.FromStream(new MemoryStream(bytes));
        }

        public static Bitmap ResizeImage(Image image, int width, int height) {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static byte[] OpenImage(string imagePath) {
            byte[] image = null;

            try {
                image = File.ReadAllBytes(imagePath);
            }
            catch {
                Program.ShowErrorBox("Failed to open poster image");
            }

            return image;
        }
    }
}
