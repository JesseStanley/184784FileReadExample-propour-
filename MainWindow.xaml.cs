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

namespace _184784fileReadExample
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

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr =
                    new System.IO.StreamReader("BirthdayList.txt");
                while (!sr.EndOfStream)
                {
                    lblOutput.Content += sr.ReadLine() + Environment.NewLine;
                }
                sr.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadFile2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr =
                    new System.IO.StreamReader("TextFile1.txt");
                lblOutput.Content = "";
                string output = "";
                while (!sr.EndOfStream)
                {
                    string fullName = sr.ReadLine();
                    string[] names =
                        fullName.Split(new char[] { ',' });
                    output += names[1] + Environment.NewLine;
                }
                lblOutput.Content = output;
                sr.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
