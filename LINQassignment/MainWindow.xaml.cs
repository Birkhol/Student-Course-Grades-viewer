using LINQassignment.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
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

namespace LINQassignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly Dat154Context dx = new();

        private readonly ObservableCollection<Student> Students = [];

        public MainWindow()
        {
            InitializeComponent();

            Students = dx.Students.Local.ToObservableCollection();

            dx.Students.Load();

            studentList.DataContext = Students;

        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            dx.Students.Where(x => x.Studentname.Contains(Search.Text));

            studentList.DataContext = Students.Where(x => x.Studentname.Contains(Search.Text)).OrderBy(x => x.Id).ToList();
        }

        private void EditButton_Click_1(object sender, RoutedEventArgs e) {

            Editor editor = new()
            {
                dx = dx
            };
            editor.Show();
        }

        private void studentList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Student s = studentList.SelectedItem as Student;

            if (s != null)
            {
                Editor editor = new(s)
                {
                    dx = dx
                };
                editor.Show();
            }

        }

    }
}