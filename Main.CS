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

namespace Tugashova4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var context = HospitalEntities.GetContext();

            DepartmentsGrid.ItemsSource = context.Department.ToList();
            WardsGrid.ItemsSource = context.Ward.Include("Department").ToList();
            SicksGrid.ItemsSource = context.Sick.Include("Ward").ToList();
            PostsGrid.ItemsSource = context.Post.ToList();
            WorkersGrid.ItemsSource = context.Worker.Include("Post").Include("Department").ToList();
            QualificationsGrid.ItemsSource = context.Qualification.ToList();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var addInfo = new AddInfo();
            addInfo.ShowDialog();
            LoadData(); // Обновляем данные после закрытия окна
        }
    }
}
