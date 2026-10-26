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

namespace KatalogOkienkowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Produkt> produkty = new List<Produkt>();

            produkty.Add(new Produkt("Procesor", 899.00, "Electronic", 10));
            produkty.Add(new Produkt("Pamięć RAM", 565.05, "Electronic", 3));
            produkty.Add(new Produkt("Dysk SSD", 44.99, "Electronic", 1));
            produkty.Add(new Produkt("Zasilacz", 189.99, "Electronic", 5));

            LiczbaProuktuw.Text = $"Liczba produktuw: {produkty.Count()}";
        }
    }
}