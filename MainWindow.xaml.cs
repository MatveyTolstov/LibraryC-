using System.Windows;
using Microsoft.Win32;
using SerorDel;


namespace Library
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
                InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SerorDel.Class1.Serializee(TextBx.Text, "mama");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            string file = openFileDialog.FileName;
            if (file != null)
            {
                var result = SerorDel.Class1.DeserializeFromFile<object>(file);
                TextBx.Text = result.ToString();
            }

            
        }
    }
}
