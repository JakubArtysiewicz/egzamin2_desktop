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
            this.Rlabel.Content = 255;
            this.Glabel.Content = 255;
            this.Blabel.Content = 255;
            this.Pobrane.Content = "255,255,255";
        }
        private void RGBBackgroundColorChange()
        {
            byte RsliderValue = (byte)this.Rslider.Value;
            byte GsliderValue = (byte)this.Gslider.Value;
            byte BsliderValue = (byte)this.Bslider.Value;
            RGBlabel.Background = new SolidColorBrush(Color.FromRgb(RsliderValue, GsliderValue, BsliderValue));
        }

        private void onRSliderChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte RsliderValue = (byte)this.Rslider.Value;
            RGBBackgroundColorChange();
            this.Rlabel.Content = RsliderValue.ToString();        
        }

        private void onGSliderChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte GsliderValue = (byte)this.Gslider.Value;
            RGBBackgroundColorChange();
            this.Glabel.Content = GsliderValue.ToString();
        }

        private void onBSliderChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte BsliderValue = (byte)this.Bslider.Value;
            RGBBackgroundColorChange();
            this.Blabel.Content = BsliderValue.ToString();
        }

        private void PobierzClick(object sender, RoutedEventArgs e)
        {
            byte RsliderValue = (byte)this.Rslider.Value;
            byte GsliderValue = (byte)this.Gslider.Value;
            byte BsliderValue = (byte)this.Bslider.Value;
            this.Pobrane.Content = RsliderValue.ToString() + "," + GsliderValue.ToString() + "," + BsliderValue.ToString(); 
            Pobrane.Background = new SolidColorBrush(Color.FromRgb(RsliderValue, GsliderValue, BsliderValue));
        }
    }
}