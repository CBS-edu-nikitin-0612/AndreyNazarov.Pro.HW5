using System.Windows;
using System.Windows.Controls;
using System.Configuration;

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Configuration cfg;
        public MainWindow()
        {
            InitializeComponent();
            cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            TextBox2.Text = cfg.AppSettings.Settings["text"].Value;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }

        private void Save()
        {
            cfg.AppSettings.Settings["text"].Value = TextBox.Text;
            TextBox2.Text = cfg.AppSettings.Settings["text"].Value;
            TextBox.Text = "";
            cfg.Save();
        }
    }
}
