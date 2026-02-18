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
            this.Rslider.Value = 255;
            this.Gslider.Value = 255;
            this.Bslider.Value = 255;
        }
        private void onSliderChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RGBBackgroundColorChange();
        }
        private void RGBBackgroundColorChange()
        {
            byte RsliderValue = (byte)this.Rslider.Value;
            byte GsliderValue = (byte)this.Gslider.Value;
            byte BsliderValue = (byte)this.Bslider.Value;
            RGBlabel.Background = new SolidColorBrush(Color.FromRgb(RsliderValue, GsliderValue, BsliderValue));
        }
    }
}