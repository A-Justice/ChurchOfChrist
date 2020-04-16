using System;
using System.Globalization;
using System.IO;
using System.Windows.Media.Imaging;

namespace ShortBody.ValueConverters
{
    public class ByteToImageConverter : BaseConverter<ByteToImageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                byte[] logo = value as byte[] ?? new byte[3];
                MemoryStream stream = new MemoryStream();
                stream.Write(logo, 0, logo.Length);
                stream.Position = 0;

                System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();

                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                ms.Seek(0, SeekOrigin.Begin);
                bi.StreamSource = ms;
                bi.EndInit();
                return bi;
            }
            catch { return null; }

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
            var bmImageStream = (value as BitmapImage).StreamSource;
            byte[] logo = new byte[bmImageStream.Length];
            bmImageStream.Read(logo, 0, logo.Length);
            return logo;


        }
    }
}
