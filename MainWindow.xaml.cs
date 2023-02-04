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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void SzinKeveres()
        {
            rtcTeglalap.Fill = new SolidColorBrush(
                Color.FromRgb(
                    Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
        }

        private void sliRGB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SzinKeveres();
            lbPirosErtek.Content = Convert.ToByte(sliPiros.Value);
            lbZoldErtek.Content = Convert.ToByte(sliZold.Value);
            lbKekErtek.Content = Convert.ToByte(sliKek.Value);
        }
        public MainWindow()
        {

            InitializeComponent();
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            if (!lbSzinek.Items.Contains((Color.FromRgb(Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)))))
            {
                lbSzinek.Items.Add(Color.FromRgb(Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
            }
        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            lbSzinek.Items.RemoveAt(lbSzinek.SelectedIndex);
        }

        private void btnUrit_Click(object sender, RoutedEventArgs e)
        {
            lbSzinek.Items.Clear();
        }

        private void lbSzinek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ElemKiválasztva(object sender, SelectionChangedEventArgs e)
        {
            string[] tagok = lbSzinek.SelectedItem.ToString().Split(';');
            rtcTeglalap.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(tagok[0]), Convert.ToByte(tagok[1]), Convert.ToByte(tagok[2])));
        }
    }
}
