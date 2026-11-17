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

namespace Dolgozatok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Dolgozat
    {
        public string Nev { get; set; }
        public int Eletkor { get; set; }
        public int Pontszam { get; set; }

        public Dolgozat(string nev, int eletkor, int pontszam)
        {
            Nev = nev;
            Eletkor = eletkor;
            Pontszam = pontszam;
        }
    }
    public partial class MainWindow : Window
    {
        List<Dolgozat> lista = new List<Dolgozat>();
        public MainWindow()
        {
            InitializeComponent();
            lista.Add(new Dolgozat("Kiss Péter", 16, 87));
            lista.Add(new Dolgozat("Nagy Anna", 17, 92));
            lista.Add(new Dolgozat("Szabó Tamás", 16, 78));
            lista.Add(new Dolgozat("Tóth Éva", 18, 95));
            lista.Add(new Dolgozat("Varga Bence", 17, 81));
            lista.Add(new Dolgozat("Horváth Zsolt", 16, 65));
            lista.Add(new Dolgozat("Molnár Réka", 18, 89));
            lista.Add(new Dolgozat("Lakatos Dániel", 17, 72));
            tabla.ItemsSource = lista;
        }

        private void hozzaad_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ment_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}