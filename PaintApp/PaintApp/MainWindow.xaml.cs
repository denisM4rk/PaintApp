using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Markup;
using Microsoft.Win32;

namespace PaintApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 0;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
        }
        public class ColorRGB
        {
            public byte red { get; set; }
            public byte green { get; set; }
            public byte blue { get; set; }
        }

        public ColorRGB mcolor { get; set; }

        public Color clr { get; set; }

        private void sld_Color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            string crlName = slider.Name; 
            double value = slider.Value; 
                                        
            if (crlName.Equals("sld_RedColor"))
            {
                mcolor.red = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_GreenColor"))
            {
                mcolor.green = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_BlueColor"))
            {
                mcolor.blue = Convert.ToByte(value);
            }

            
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            
            this.inkCanvas.DefaultDrawingAttributes.Color = clr;
        }

        private void buttonClear(object sender, RoutedEventArgs e)
        {
            this.inkCanvas.Strokes.Clear(); 
        }

        private void buttonClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonSave(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "savedimage"; 
            dlg.DefaultExt = ".jpg"; 
            dlg.Filter = "Image (.jpg)|*.jpg"; 

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
                int margin = (int)this.inkCanvas.Margin.Left;
                int width = (int)this.inkCanvas.ActualWidth - margin;
                int height = (int)this.inkCanvas.ActualHeight - margin;

                RenderTargetBitmap rtb = new RenderTargetBitmap(width, height, 96d, 96d, PixelFormats.Default);
                rtb.Render(inkCanvas);

                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    BmpBitmapEncoder encoder = new BmpBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(rtb));
                    encoder.Save(fs);
                }
            }
        }
    }
}
