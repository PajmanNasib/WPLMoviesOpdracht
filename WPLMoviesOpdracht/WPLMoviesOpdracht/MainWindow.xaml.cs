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

namespace WPLMoviesOpdracht
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

        private void DuneBtn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ResultTxt.Text = "Dune: Part Two\r\nPaul Atreides unites with Chani and the Fremen while seeking revenge against the conspirators who destroyed his family.";
        }

        private void FuriosaBtn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ResultTxt.Text = "The Substance\r\nA fading celebrity decides to use a black-market drug, a cell-replicating substance that temporarily creates a younger, better version of herself.";
        }

        private void lastOneBtn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ResultTxt.Text = "Furiosa: A Mad Max Saga\r\nThe origin story of renegade warrior Furiosa before her encounter and teamup with Mad Max.";
        }
    }
}
