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
using System.Windows.Shapes;
using FlightSimulator.Model;
namespace FlightSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Closed += closeWindow;
            InitializeComponent();
        }
        private void closeWindow(object sender, EventArgs e)
        {
            if (Server.getInstnace.isServerOpen())
            {
                Server.getInstnace.close();
            }
            if (Instructions.getInstance.isOpen())
            {
                Instructions.getInstance.close();
            }
        }
    }
}
