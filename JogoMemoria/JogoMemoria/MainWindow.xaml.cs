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

namespace JogoMemoria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<BitmapImage> imagens = new List<BitmapImage>();
        public MainWindow()
        {
            InitializeComponent();

            //ramdom rnd = new ramdom();


            imagens.Add(new BitmapImage(new System.Uri("JogoMemoria\\img\\comunismo")));

            var img1 = new BitmapImage(new System.Uri("pack://application:,,,/Images/csharp.png"));
            var img2 = new BitmapImage(new System.Uri("pack://application:,,,/Images/java.png"));
            var img3 = new BitmapImage(new System.Uri("pack://application:,,,/Images/python.png"));
            var img4 = new BitmapImage(new System.Uri("pack://application:,,,/Images/javascript.png"));
            var img5 = new BitmapImage(new System.Uri("pack://application:,,,/Images/ruby.png"));
            var img6 = new BitmapImage(new System.Uri("pack://application:,,,/Images/swift.png"));
        }

        private void bt_1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}