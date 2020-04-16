using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Printing;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using wf = System.Windows.Forms;
namespace ShortBody.Resources.Helper_Methods
{
    public class Methods
    {

        #region PrintHandles
        public static void alloPrint(object sender)
        {
            // 
            Visual v = sender as Visual;
            // Visual v = song2Grid as Visual;
            // the object (it is a DataGrid) that you want to print out, not a window
            PrintDialog prtDlg = new PrintDialog();
            if (prtDlg.ShowDialog() == true)
            {
                // because 96 pixels in an inch for WPF window
                double marginLeft = 96.0 * 0.75;
                // left margin is 0.75 inches 
                double marginTop = 96.0 * 0.75;
                // top margin is 0.75 inches 
                double marginRight = 96.0 * 0.75;
                // right margin is 0.75 inches 
                double marginBottom = 96.0 * 0.75;
                // bottom margin is 0.75 inches 
                // the following steps do not works for a WPF window 
                FrameworkElement win = v as FrameworkElement;
                Transform oldLayoutTransform = win.LayoutTransform;
                Size oldSize = new Size(win.ActualWidth, win.ActualHeight);
                System.Printing.PrintCapabilities pCapability = prtDlg.PrintQueue.GetPrintCapabilities(prtDlg.PrintTicket);
                // calculate print area that you want 
                double printWidth = (pCapability.PageImageableArea.ExtentWidth - pCapability.PageImageableArea.OriginWidth) - (marginLeft + marginRight);
                double printHeight = (pCapability.PageImageableArea.ExtentHeight - pCapability.PageImageableArea.OriginHeight) - (marginTop + marginBottom);
                // calculate the scale 
                double scale = Math.Min(printWidth / oldSize.Width, printHeight / oldSize.Height);
                if (scale > 1.0)
                {
                    // keep the original size and layout if printable area is greater than the object being printed 
                    scale = 1.0;
                }
                // store the original layoutTransform
                win.LayoutTransform = new ScaleTransform(scale, scale);
                // new size of the visual 
                Size newSize = new Size(oldSize.Width * scale, oldSize.Height * scale);
                win.Measure(newSize);
                // centralize print area
                double xStartPrint = marginLeft + (printWidth - newSize.Width) / 2.0;
                double yStartPrint = marginTop + (printHeight - newSize.Height) / 2.0;
                win.Arrange(new Rect(new Point(xStartPrint, yStartPrint), newSize));
                // print out the visual 
                prtDlg.PrintVisual(win as Visual, "PrintTest");
                // resotre the original layouttransform and size on screen 
                win.LayoutTransform = oldLayoutTransform; win.Measure(oldSize);
                win.Arrange(new Rect(new Point(0, 0), oldSize));
            }
        }

        public static Task<DocumentPaginator> PrintOnMultiPage(object parameter, bool canReturn = false)
        {
            return Task.Run(() =>
            {
                if (parameter is FrameworkElement)
                {
                    FrameworkElement objectToPrint = parameter as FrameworkElement;
                    FixedDocument document = null;
                    objectToPrint.Dispatcher.BeginInvoke(new Action(() =>
                    {


                        Transform originalScale = objectToPrint.LayoutTransform;
                        PrintDialog printDialog = new PrintDialog();
                        var determiner = true;
                        if (!canReturn)
                            determiner = (bool)printDialog.ShowDialog().GetValueOrDefault();
                        if (determiner)
                        {
                            // Mouse.OverrideCursor = Cursors.Wait;
                            System.Printing.PrintCapabilities capabilities = printDialog.PrintQueue.GetPrintCapabilities(printDialog.PrintTicket);
                            double dpiScale = 200.0 / 96.0;
                            document = new FixedDocument();
                            try
                            {
                                // Change the layout of the UI Control to match the width of the printer page 
                                double scale = capabilities.PageImageableArea.ExtentWidth / objectToPrint.ActualWidth;

                                objectToPrint.LayoutTransform = new ScaleTransform(scale, scale);
                                // objectToPrint.Width = capabilities.PageImageableArea.ExtentWidth ;
                                objectToPrint.UpdateLayout();
                                objectToPrint.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
                                Size size = new Size(capabilities.PageImageableArea.ExtentWidth, objectToPrint.DesiredSize.Height);
                                objectToPrint.Measure(size);
                                //size = new Size(capabilities.PageImageableArea.ExtentWidth, objectToPrint.DesiredSize.Height);
                                //objectToPrint.Measure(size);
                                objectToPrint.Arrange(new Rect(size));
                                // Convert the UI control into a bitmap at 300 dpi 
                                double dpiX = 200;
                                double dpiY = 200;
                                RenderTargetBitmap bmp = new RenderTargetBitmap(Convert.ToInt32(capabilities.PageImageableArea.ExtentWidth * dpiScale), Convert.ToInt32(objectToPrint.ActualHeight * dpiScale), dpiX, dpiY, PixelFormats.Pbgra32);
                                bmp.Render(objectToPrint);
                                // Convert the RenderTargetBitmap into a bitmap we can more readily use 
                                PngBitmapEncoder png = new PngBitmapEncoder();
                                png.Frames.Add(BitmapFrame.Create(bmp));
                                System.Drawing.Bitmap bmp2;
                                using (MemoryStream memoryStream = new MemoryStream())
                                {
                                    png.Save(memoryStream);
                                    bmp2 = new System.Drawing.Bitmap(memoryStream);
                                }
                                document.DocumentPaginator.PageSize = new Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
                                // break the bitmap down into pages 
                                int pageBreak = 0;
                                int previousPageBreak = 0;
                                int pageHeight = Convert.ToInt32(capabilities.PageImageableArea.ExtentHeight * dpiScale);
                                while (pageBreak < bmp2.Height - pageHeight)
                                {

                                    pageBreak += pageHeight;
                                    // Where we thing the end of the page should be 
                                    // Keep moving up a row until we find a good place to break the page 
                                    while (!IsRowGoodBreakingPoint(bmp2, pageBreak))
                                        pageBreak--;
                                    PageContent pageContent = generatePageContent(bmp2, previousPageBreak, pageBreak, document.DocumentPaginator.PageSize.Width, document.DocumentPaginator.PageSize.Height, capabilities);
                                    document.Pages.Add(pageContent);
                                    previousPageBreak = pageBreak;

                                }
                                // Last Page 
                                PageContent lastPageContent = generatePageContent(bmp2, previousPageBreak, bmp2.Height, document.DocumentPaginator.PageSize.Width, document.DocumentPaginator.PageSize.Height, capabilities);

                                document.Pages.Add(lastPageContent);


                            }
                            catch
                            {
                                //  MessageBox.Show(ex.Message, "An Error Occured");
                            }
                            finally
                            {
                                if (!canReturn)
                                {
                                    printDialog.PrintDocument(document.DocumentPaginator, "Print Document Name");
                                    MessageBox.Show("Printing SuccessFul", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                                }


                                // Scale UI control back to the original so we don't effect what is on the screen 
                                //objectToPrint.Width = double.NaN;
                                //objectToPrint.UpdateLayout();
                                objectToPrint.LayoutTransform = originalScale;
                                Size size = new Size(capabilities.PageImageableArea.ExtentWidth, capabilities.PageImageableArea.ExtentHeight);
                                objectToPrint.Measure(size);
                                objectToPrint.Arrange(new Rect(new Point(capabilities.PageImageableArea.OriginWidth, capabilities.PageImageableArea.OriginHeight), size));
                                // Mouse.OverrideCursor = null;
                            }

                        }

                    }));


                    if (!canReturn)
                        return null;
                    return document.DocumentPaginator;
                }

                return null;
            });

        }

        private static PageMediaSize A4PaperSize = new PageMediaSize(816, 1248);



        //public static void PrintPreview(Window owner, object data,bool IsSinglePage = false)
        //{

        //    using (MemoryStream xpsStream = new MemoryStream())
        //    {

        //        using (Package package = Package.Open(xpsStream, FileMode.Create, FileAccess.ReadWrite))
        //        {

        //            string packageUriString = "memorystream://data.xps";

        //            Uri packageUri = new Uri(packageUriString);


        //            if (PackageStore.GetPackage(packageUri) != null)
        //            {
        //                PackageStore.RemovePackage(packageUri);
        //            }
        //            PackageStore.AddPackage(packageUri, package);



        //            XpsDocument xpsDocument = new XpsDocument(package, CompressionOption.NotCompressed, packageUriString);

        //            XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(xpsDocument);

        //            // Form visual = new Form();



        //            // PrintTicket printTicket = new PrintTicket();

        //            //  printTicket.PageMediaSize = A4PaperSize;
        //            // var d = PrintOnMultiPage(data, true);
        //            //((IDocumentPaginatorSource)data).DocumentPaginator
        //            if (!IsSinglePage)
        //                writer.Write(PrintOnMultiPage(data, true));
        //            else
        //                writer.Write(Print((Visual)data,true));

        //            FixedDocumentSequence document = xpsDocument.GetFixedDocumentSequence();

        //            xpsDocument.Close();



        //            PrintPreviewWindow printPreviewWnd = new PrintPreviewWindow(document);

        //            printPreviewWnd.Owner = owner;

        //            printPreviewWnd.ShowDialog();

        //            PackageStore.RemovePackage(packageUri);

        //        }

        //    }

        //}



        public static Task<Visual> Print(Visual v, bool canReturn = false)
        {
            return Task<Visual>.Run(() =>
             {
                 try
                 {
                     System.Windows.FrameworkElement e = v as System.Windows.FrameworkElement;

                     e.Dispatcher.BeginInvoke(new Action(() =>
                     {

                         if (e == null)
                             return;
                         PrintDialog pd = new PrintDialog();

                         bool? determiner = true;

                         if (!canReturn)
                             determiner = pd.ShowDialog();


                         if ((bool)determiner)
                         {
                             //store original scale
                             Transform originalScale = e.LayoutTransform;
                             //get selected printer capabilities 
                             System.Printing.PrintCapabilities capabilities = pd.PrintQueue.GetPrintCapabilities(pd.PrintTicket);
                             //get scale of the print wrt to screen of WPF visual 
                             //double x = capabilities.PageImageableArea.ExtentWidth / e.ActualWidth;
                             //double y = capabilities.PageImageableArea.ExtentHeight / e.ActualHeight;
                             double scale = Math.Min(capabilities.PageImageableArea.ExtentWidth / e.ActualWidth, capabilities.PageImageableArea.ExtentHeight / e.ActualHeight);
                             //Transform the Visual to scale 
                             e.LayoutTransform = new ScaleTransform(scale, scale);
                             //  e.LayoutTransform = new ScaleTransform(x, y);
                             //get the size of the printer page
                             System.Windows.Size sz = new System.Windows.Size(capabilities.PageImageableArea.ExtentWidth, capabilities.PageImageableArea.ExtentHeight);
                             //update the layout of the visual to the printer page size. 
                             e.Measure(sz);
                             e.Arrange(new System.Windows.Rect(new System.Windows.Point(capabilities.PageImageableArea.OriginWidth, capabilities.PageImageableArea.OriginHeight), sz));
                             //now print the visual to printer to fit on the one page. 
                             if (!canReturn)
                             {
                                 pd.PrintVisual(v, "My Print");
                                 //apply the original transform.
                                 e.LayoutTransform = originalScale;
                                 MessageBox.Show("Printing SuccessFul", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);

                             }


                         }

                     }));

                     if (canReturn)
                         return v;
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }

                 return null;
             });


        }
        #endregion

        #region PrintHelpers
        private static PageContent generatePageContent(System.Drawing.Bitmap bmp, int top, int bottom, double pageWidth, double PageHeight, System.Printing.PrintCapabilities capabilities)
        {
            FixedPage printDocumentPage = new FixedPage();
            printDocumentPage.Width = pageWidth;
            printDocumentPage.Height = PageHeight;
            int newImageHeight = bottom - top;
            System.Drawing.Bitmap bmpPage = bmp.Clone(new System.Drawing.Rectangle(0, top, bmp.Width, newImageHeight), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            // Create a new bitmap for the contents of this page 
            Image pageImage = new Image();
            BitmapSource bmpSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(bmpPage.GetHbitmap(), IntPtr.Zero, System.Windows.Int32Rect.Empty, BitmapSizeOptions.FromWidthAndHeight(bmp.Width, newImageHeight));
            pageImage.Source = bmpSource;
            pageImage.VerticalAlignment = VerticalAlignment.Top;
            // Place the bitmap on the page 
            printDocumentPage.Children.Add(pageImage);
            PageContent pageContent = new PageContent();
            ((System.Windows.Markup.IAddChild)pageContent).AddChild(printDocumentPage);
            FixedPage.SetLeft(pageImage, capabilities.PageImageableArea.OriginWidth);
            FixedPage.SetTop(pageImage, capabilities.PageImageableArea.OriginHeight);
            pageImage.Width = capabilities.PageImageableArea.ExtentWidth;
            pageImage.Height = capabilities.PageImageableArea.ExtentHeight;
            return pageContent;
        }

        private static bool IsRowGoodBreakingPoint(System.Drawing.Bitmap bmp, int row)
        {
            double maxDeviationForEmptyLine = 1627500;
            bool goodBreakingPoint = false;
            if (rowPixelDeviation(bmp, row) < maxDeviationForEmptyLine) goodBreakingPoint = true;
            return goodBreakingPoint;
        }


        private static double rowPixelDeviation(System.Drawing.Bitmap bmp, int row)
        {
            int count = 0;
            double total = 0;
            double totalVariance = 0;
            double standardDeviation = 0;
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, bmp.PixelFormat);
            int stride = bmpData.Stride;
            IntPtr firstPixelInImage = bmpData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)firstPixelInImage;
                p += stride * row;
                // find starting pixel of the specified row 
                for (int column = 0; column < bmp.Width; column++)
                {
                    count++;
                    //count the pixels
                    byte blue = p[0];
                    byte green = p[1];
                    byte red = p[3];
                    int pixelValue = System.Drawing.Color.FromArgb(0, red, green, blue).ToArgb();
                    total += pixelValue;
                    double average = total / count; totalVariance += Math.Pow(pixelValue - average, 2);
                    standardDeviation = Math.Sqrt(totalVariance / count);
                    // go to next pixel p += 3;
                }
            }
            bmp.UnlockBits(bmpData);
            return standardDeviation;
        }


        #endregion

        #region BackUp
        public static void Backup(bool IsCustomPath = false)
        {
            string DestinationPath = Environment.CurrentDirectory;

            if (IsCustomPath)
            {
                wf.FolderBrowserDialog fdialog = new wf.FolderBrowserDialog();

                if (fdialog.ShowDialog() == wf.DialogResult.OK)
                {
                    DestinationPath = fdialog.SelectedPath;
                }
                else
                    return;
            }





            DirectoryInfo SourceFileName = new DirectoryInfo(Environment.CurrentDirectory + "/shortbodydb.sdf");
            string DestinationFolderName = DestinationPath + @"/" + "Backup";
            Directory.CreateDirectory(DestinationFolderName);
            File.Copy(SourceFileName.FullName, DestinationFolderName + @"/" + SourceFileName.Name, true);


            ZipFile.CreateFromDirectory(DestinationFolderName, DestinationFolderName + ".zip");
            FileInfo fInfo = new FileInfo(DestinationFolderName + ".comp");
            //fInfo.Create();
            File.Create(DestinationFolderName + ".comp").Dispose();
            File.Copy(DestinationFolderName + ".zip", fInfo.FullName, true);
            File.Delete(DestinationFolderName + ".zip");
            Directory.Delete(DestinationFolderName, true);

            if (IsCustomPath)
                MessageBox.Show("Backup Successful !", "Operation Completed", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        public static void Backup()
        {
            string DestinationPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            DirectoryInfo SourceFileName = new DirectoryInfo(Environment.CurrentDirectory + "/shortbodydb.sdf");
            string DestinationFolderName = DestinationPath + @"/" + "Backup";
            Directory.CreateDirectory(DestinationFolderName);
            File.Copy(SourceFileName.FullName, DestinationFolderName + @"/" + SourceFileName.Name, true);


            ZipFile.CreateFromDirectory(DestinationFolderName, DestinationFolderName + ".zip");
            FileInfo fInfo = new FileInfo(DestinationFolderName + ".comp");
            //fInfo.Create();
            File.Create(DestinationFolderName + ".comp").Dispose();
            File.Copy(DestinationFolderName + ".zip", fInfo.FullName, true);
            File.Delete(DestinationFolderName + ".zip");
            Directory.Delete(DestinationFolderName, true);

        }

        public static void Restore(bool IsCustomPath = false)
        {
            if (MessageBox.Show("Database Restoration would Require Application Restart ,Do you want to proceed", "Application Restart Required", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.No)
                return;

            string sourceCompFile;
            if (IsCustomPath)
            {
                wf.OpenFileDialog dialog = new wf.OpenFileDialog();
                dialog.Filter = ".comp|*.comp";
                dialog.Title = "Choose the Backup File";

                if (dialog.ShowDialog() == wf.DialogResult.OK)
                {
                    sourceCompFile = dialog.FileName;
                }
                else
                    return;
            }
            else
                sourceCompFile = Environment.CurrentDirectory + @"/" + "Backup.comp";

            try
            {

                string sourceZFile = sourceCompFile.Substring(0, sourceCompFile.LastIndexOf('.')) + ".zip";

                File.Copy(sourceCompFile, sourceZFile, true);
                File.Delete(Environment.CurrentDirectory + "/shortbodydb.sdf");
                ZipFile.ExtractToDirectory(sourceZFile, Environment.CurrentDirectory);
                File.Delete(sourceZFile);
                if (IsCustomPath)
                    MessageBox.Show("Application Backup Successfully restored", "BackUp Restored");
                else
                    MessageBox.Show("DataBase changes successfuly reverted", "Restore Successful");

                Process.Start(Application.ResourceAssembly.Location);
                Application.Current.Shutdown();

                // MainWindowViewModel._CurrentPage = ApplicationPage.Login;
            }
            catch { MessageBox.Show("Failed To Restore Backup"); }



        }
        #endregion  

        public static void PreviewMouseWheelEventHandler(object sender, MouseWheelEventArgs e)
        {
            try
            {
                e.Handled = true;
                var eventArgs = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);

                eventArgs.RoutedEvent = UIElement.MouseWheelEvent;
                eventArgs.Source = sender;

                object parent = null;
                parent = (((Control)sender).TemplatedParent as UIElement);

                if (parent == null)
                {
                    parent = ((Control)sender).Parent;
                }


                ((dynamic)parent)?.RaiseEvent(eventArgs);
            }
            catch { }

        }
        public static IEnumerable<int> GenerateYears()
        {
            foreach (var item in Enumerable.Range(2015, DateTime.Now.Year - 2013))
            {
                yield return item;
            }
        }

        public static string GetComboBoxText(object sender)
        {
            return ((sender as ComboBox)?.SelectedValue as ComboBoxItem)?.Content.ToString();
        }

        #region ChoosePicture

        public static object[] BrowsePic()
        {
            object pic = null;
            string imageName = null;
            try
            {

                FileDialog fldlg = new OpenFileDialog();
                fldlg.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();
                fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
                fldlg.ShowDialog();
                {
                    // strName = fldlg.SafeFileName;
                    imageName = fldlg.FileName;
                    ImageSourceConverter isc = new ImageSourceConverter();
                    pic = isc.ConvertFromString(imageName);
                    //  imgBox.SetValue(Image.SourceProperty,);
                }
                fldlg = null;

            }
            catch
            {

            }
            return new object[] { imageName, pic };
        }


        public static byte[] GetImageBytes(string imageName)
        {
            try
            {
                byte[] imgByteArr = null;
                try
                {
                    if (imageName != "")
                    {
                        //Initialize a file stream to read the image file
                        FileStream fs = new FileStream(imageName, FileMode.Open, FileAccess.Read);

                        //Initialize a byte array with size of stream
                        imgByteArr = new byte[fs.Length];

                        //Read data from the file stream and put into the byte array
                        fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));

                        //Close a file stream
                        fs.Close();
                    }

                    return imgByteArr ?? null;
                }
                catch
                {
                    //MessageBox.Show(ex.Message);
                    return null;
                }
            }
            catch { return null; }

        }
        #endregion
    }
}
