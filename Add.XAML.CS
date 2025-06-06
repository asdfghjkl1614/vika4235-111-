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

namespace Tugashova4
{
    /// <summary>
    /// Логика взаимодействия для AddInfo.xaml
    /// </summary>
    public partial class AddInfo : Window
    {
        private HospitalEntities _context = HospitalEntities.GetContext();
        public AddInfo()
        {
            InitializeComponent();
            LoadAllData();
        }
        private void LoadAllData()
        {
            // Отделения
            EditDepartmentsGrid.ItemsSource = _context.Department.ToList();

            // Палаты
            EditWardsGrid.ItemsSource = _context.Ward.ToList();
            ((DataGridComboBoxColumn)EditWardsGrid.Columns[3]).ItemsSource = _context.Department.ToList();

            // Пациенты
            EditSicksGrid.ItemsSource = _context.Sick.ToList();
            ((DataGridComboBoxColumn)EditSicksGrid.Columns[4]).ItemsSource = _context.Ward.ToList();

            // Должности
            EditPostsGrid.ItemsSource = _context.Post.ToList();

            // Сотрудники
            EditWorkersGrid.ItemsSource = _context.Worker.ToList();
            ((DataGridComboBoxColumn)EditWorkersGrid.Columns[4]).ItemsSource = _context.Post.ToList();
            ((DataGridComboBoxColumn)EditWorkersGrid.Columns[5]).ItemsSource = _context.Department.ToList();

            // Квалификации
            EditQualificationsGrid.ItemsSource = _context.Qualification.ToList();
        }

        #region Отделения
        private void AddDepartment_Click(object sender, RoutedEventArgs e)
        {
            _context.Department.Add(new Department { Title = "Новое отделение" });
            EditDepartmentsGrid.ItemsSource = _context.Department.ToList();
        }

        private void SaveDepartment_Click(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();
            MessageBox.Show("Отделения сохранены");
        }

        private void DeleteDepartment_Click(object sender, RoutedEventArgs e)
        {
            if (EditDepartmentsGrid.SelectedItem is Department selected)
            {
                if (MessageBox.Show("Удалить это отделение?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    _context.Department.Remove(selected);
                    _context.SaveChanges();
                    EditDepartmentsGrid.ItemsSource = _context.Department.ToList();
                }
            }
        }
        #endregion

        #region Палаты
        private void AddWard_Click(object sender, RoutedEventArgs e)
        {
            _context.Ward.Add(new Ward { Number_of_beds = 1 });
            EditWardsGrid.ItemsSource = _context.Ward.ToList();
        }

        private void SaveWard_Click(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();
            MessageBox.Show("Палаты сохранены");
        }

        private void DeleteWard_Click(object sender, RoutedEventArgs e)
        {
            if (EditWardsGrid.SelectedItem is Ward selected)
            {
                if (MessageBox.Show("Удалить эту палату?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    _context.Ward.Remove(selected);
                    _context.SaveChanges();
                    EditWardsGrid.ItemsSource = _context.Ward.ToList();
                }
            }
        }
        #endregion

        #region Пациенты
        private void AddSick_Click(object sender, RoutedEventArgs e)
        {
            _context.Sick.Add(new Sick { Full_name = "Новый пациент" });
            EditSicksGrid.ItemsSource = _context.Sick.ToList();
        }

        private void SaveSick_Click(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();
            MessageBox.Show("Пациенты сохранены");
        }

        private void DeleteSick_Click(object sender, RoutedEventArgs e)
        {
            if (EditSicksGrid.SelectedItem is Sick selected)
            {
                if (MessageBox.Show("Удалить этого пациента?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    _context.Sick.Remove(selected);
                    _context.SaveChanges();
                    EditSicksGrid.ItemsSource = _context.Sick.ToList();
                }
            }
        }
        #endregion

        #region Должности
        private void AddPost_Click(object sender, RoutedEventArgs e)
        {
            _context.Post.Add(new Post { Title = "Новая должность" });
            EditPostsGrid.ItemsSource = _context.Post.ToList();
        }

        private void SavePost_Click(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();
            MessageBox.Show("Должности сохранены");
        }

        private void DeletePost_Click(object sender, RoutedEventArgs e)
        {
            if (EditPostsGrid.SelectedItem is Post selected)
            {
                if (MessageBox.Show("Удалить эту должность?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    _context.Post.Remove(selected);
                    _context.SaveChanges();
                    EditPostsGrid.ItemsSource = _context.Post.ToList();
                }
            }
        }
        #endregion

        #region Сотрудники
        private void AddWorker_Click(object sender, RoutedEventArgs e)
        {
            _context.Worker.Add(new Worker { Full_name = "Новый сотрудник" });
            EditWorkersGrid.ItemsSource = _context.Worker.ToList();
        }

        private void SaveWorker_Click(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();
            MessageBox.Show("Сотрудники сохранены");
        }

        private void DeleteWorker_Click(object sender, RoutedEventArgs e)
        {
            if (EditWorkersGrid.SelectedItem is Worker selected)
            {
                if (MessageBox.Show("Удалить этого сотрудника?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    _context.Worker.Remove(selected);
                    _context.SaveChanges();
                    EditWorkersGrid.ItemsSource = _context.Worker.ToList();
                }
            }
        }
        #endregion

        #region Квалификации
        private void AddQualification_Click(object sender, RoutedEventArgs e)
        {
            _context.Qualification.Add(new Qualification { Title = "Новая квалификация" });
            EditQualificationsGrid.ItemsSource = _context.Qualification.ToList();
        }

        private void SaveQualification_Click(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();
            MessageBox.Show("Квалификации сохранены");
        }

        private void DeleteQualification_Click(object sender, RoutedEventArgs e)
        {
            if (EditQualificationsGrid.SelectedItem is Qualification selected)
            {
                if (MessageBox.Show("Удалить эту квалификацию?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    _context.Qualification.Remove(selected);
                    _context.SaveChanges();
                    EditQualificationsGrid.ItemsSource = _context.Qualification.ToList();
                }
            }
        }
        #endregion
    }
}
