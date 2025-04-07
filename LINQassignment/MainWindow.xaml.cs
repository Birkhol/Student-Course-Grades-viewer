using LINQassignment.Models;
using Microsoft.Data.SqlClient;
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

        private readonly ObservableCollection<Course> Course = [];

        private readonly ObservableCollection<Grade> Grades = [];

        private string? selectedCourseCode = null;

        public MainWindow()
        {

            InitializeComponent();

            Students = dx.Students.Local.ToObservableCollection();

            dx.Students.Load();

            studentList.DataContext = Students;

            CourseDropdown.ItemsSource = dx.Courses
                .OrderBy(c => c.Coursecode)
                .Select(c => c.Coursecode)
                .ToList();

            GradeDropdown.ItemsSource = new List<string> { "A", "B", "C", "D", "E", "F" };



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

        private void CourseDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCourseCode = CourseDropdown.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(selectedCourseCode)) return;

            var result = dx.Grades
                .Include(g => g.Student)
                .Include(g => g.CoursecodeNavigation)
                .Where(g => g.Coursecode == selectedCourseCode)
                .Select(g => new
                {
                    g.Student.Id,
                    Studentname = g.Student.Studentname,
                    Studentage = g.Student.Studentage,
                    g.Coursecode,
                    Grades = g.Grade1,
                    Coursename = g.CoursecodeNavigation.Coursename,
                    Teacher = g.CoursecodeNavigation.Teacher
                })
                .ToList();

            studentList.DataContext = result;
        }

        private void GradeDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                if (GradeDropdown.SelectedItem != null)
                {
                    var selectedGrade = GradeDropdown.SelectedItem.ToString();

                    var studentsWithBetterGrades = dx.Grades
                        .Where(g => g.Coursecode == selectedCourseCode && string.Compare(g.Grade1, selectedGrade) <= 0)
                        .Include(g => g.Student)
                        .Include(g => g.CoursecodeNavigation)
                        .Select(g => new
                        {
                            g.Student.Id,
                            Studentname = g.Student.Studentname,
                            Studentage = g.Student.Studentage,
                            g.Coursecode,
                            Grades = g.Grade1,
                            Coursename= g.CoursecodeNavigation.Coursename,
                            Teacher = g.CoursecodeNavigation.Teacher
                        })
                        .ToList();

                    studentList.DataContext = studentsWithBetterGrades;
                }
        }

        private void failedButton_Click(object sender, RoutedEventArgs e)
        {
            var failedStudents = dx.Grades
                .Where(g => g.Grade1 == "F")
                .Include(g => g.Student)
                .Include(g => g.CoursecodeNavigation)
                .Select(g => new
                {
                    g.Student.Id,
                    Studentname = g.Student.Studentname,
                    Studentage = g.Student.Studentage,
                    g.Coursecode,
                    Grades = g.Grade1,
                    Coursename = g.CoursecodeNavigation.Coursename,
                    Teacher = g.CoursecodeNavigation.Teacher
                })
                .ToList();
            studentList.DataContext = failedStudents;
        }
    }
}