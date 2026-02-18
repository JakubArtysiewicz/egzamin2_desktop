using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace egzamin2_desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void onSliderChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RGBBackgroundColorChange();
        }
        private void RGBBackgroundColorChange()
        {
            byte Rslider = (byte)this.Rslider.Value;
            byte Gslider = (byte)this.Gslider.Value;
            byte Bslider = (byte)this.Bslider.Value;
            RGBlabel.Background = new SolidColorBrush(Color.FromRgb(Rslider, Gslider, Bslider));
        }
    }
}