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

namespace Shop_KopytovaPr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<object> AllItems = Classes.RepoItems.AllItems();
        public MainWindow()
        {
            InitializeComponent();
            CreateUI(AllItems);
        }
        public void CreateUI(IEnumerable<object> items)
        {
            parent.Children.Clear();
            foreach (object Item in items)
            {
                parent.Children.Add(new Elements.Item(Item));
            }
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string query = tb_Search.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                CreateUI(AllItems);
                return;
            }

            var found = AllItems
                .OfType<Classes.Shop>()
                .Where(s =>
                    (s.Name != null && s.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (s.Characteristic != null && s.Characteristic.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                )
                .Cast<object>()
                .ToList();

            CreateUI(found);

            if (found.Count == 0)
            {
                MessageBox.Show("Ничего не найдено.");
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            tb_Search.Text = "";
            CreateUI(AllItems);
        }
    }
}
