using System;
using System.Security.RightsManagement;
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
        public List<Button> btns = new List<Button>();

        public List<string> Escolhas = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            //ramdom rnd = new ramdom();


            btns.Add(bt_1);
            btns.Add(bt_2);
            btns.Add(bt_3);
            btns.Add(bt_4);
            btns.Add(bt_5);
            btns.Add(bt_6);
            btns.Add(bt_7);
            btns.Add(bt_8);
            btns.Add(bt_9);
            btns.Add(bt_10);
            btns.Add(bt_11);
            btns.Add(bt_12);


            imagens.Add(new BitmapImage(new System.Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projetos em aulas\\UltimoProjeto\\JogoMemoria\\JogoMemoria\\img\\comunismo.jpg")));
            imagens.Add(new BitmapImage(new System.Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projetos em aulas\\UltimoProjeto\\JogoMemoria\\JogoMemoria\\img\\comunismo1.jpg")));
            imagens.Add(new BitmapImage(new System.Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projetos em aulas\\UltimoProjeto\\JogoMemoria\\JogoMemoria\\img\\cara.jpg")));
            imagens.Add(new BitmapImage(new System.Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projetos em aulas\\UltimoProjeto\\JogoMemoria\\JogoMemoria\\img\\cara1.jpg")));
            imagens.Add(new BitmapImage(new System.Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projetos em aulas\\UltimoProjeto\\JogoMemoria\\JogoMemoria\\img\\bozo.jpg")));
            imagens.Add(new BitmapImage(new System.Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projetos em aulas\\UltimoProjeto\\JogoMemoria\\JogoMemoria\\img\\bozo1.jpg")));
            imagens.Add(new BitmapImage(new System.Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projetos em aulas\\UltimoProjeto\\JogoMemoria\\JogoMemoria\\img\\tim.jpg")));
            imagens.Add(new BitmapImage(new System.Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projetos em aulas\\UltimoProjeto\\JogoMemoria\\JogoMemoria\\img\\tim1.jpg")));
            imagens.Add(new BitmapImage(new System.Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projetos em aulas\\UltimoProjeto\\JogoMemoria\\JogoMemoria\\img\\maca.jpg")));
            imagens.Add(new BitmapImage(new System.Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projetos em aulas\\UltimoProjeto\\JogoMemoria\\JogoMemoria\\img\\maca1.jpg")));
            imagens.Add(new BitmapImage(new System.Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projetos em aulas\\UltimoProjeto\\JogoMemoria\\JogoMemoria\\img\\zeca.jpg")));
            imagens.Add(new BitmapImage(new System.Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projetos em aulas\\UltimoProjeto\\JogoMemoria\\JogoMemoria\\img\\zeca1.jpg")));


            Random rnd = new Random();
            imagens = imagens.OrderBy(x => rnd.Next()).ToList();

            for (int i = 0; i < btns.Count; i++)
            {
                var img = new BitmapImage(imagens[i].UriSource);
                btns[i].Content = new Image { Source = img };

            }

        }
        private void verificar(string carta)
        {
            Escolhas.Add(carta);
            if (Escolhas.Count == 2)
            {
                if (Escolhas[0] == Escolhas[1])
                {
                    MessageBox.Show("ACERTOU!");
                }
                else
                {
                    //bt_1.Visibility = Visibility.Collapsed;

                }


                Escolhas.Clear();


            }

        }
        private void bt_1_Click(object sender, RoutedEventArgs e)
        {
            var img = new BitmapImage(imagens[0].UriSource);
            var carta = img.ToString().Split('/');
            verificar(carta.Last());


        }

        private void bt_2_Click(object sender, RoutedEventArgs e)
        {
            var img = new BitmapImage(imagens[1].UriSource);
            var carta = img.ToString().Split('/');
            verificar(carta.Last());
        }

        private void r_1(object sender, MouseButtonEventArgs e)
        {
            // Esconder o retângulo que recebeu o clique
            if (sender is System.Windows.FrameworkElement fe)
            {
                fe.Visibility = Visibility.Hidden;
            }
            else
            {
                    
            }

                // Mantém a lógica existente de revelar/verificar a carta
            var img = new BitmapImage(imagens[0].UriSource);
            var carta = img.ToString().Split('/');
            verificar(carta.Last());
        }

        

        private void r_2(object sender, MouseButtonEventArgs e)
        {
            if (sender is System.Windows.FrameworkElement fe)
            {
                fe.Visibility = Visibility.Hidden;
            }

            // Mantém a lógica existente de revelar/verificar a carta
            var img = new BitmapImage(imagens[1].UriSource);
            var carta = img.ToString().Split('/');
            verificar(carta.Last());
        }




        //bt2
    }
}