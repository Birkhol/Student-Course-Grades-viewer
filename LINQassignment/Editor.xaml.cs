using Azure;
using LINQassignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
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

namespace LINQassignment
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        public Dat154Context dx { get; set; }

        public Editor()
        {
            InitializeComponent();
            Loaded += Editor_Loaded;
        }

        public Editor(Student s) : this()
        {
            sname.Text = s.Studentname;
            sid.Text = s.Id.ToString();
            sage.Text = s.Studentage.ToString();
        }
        private void Editor_Loaded(object sender, RoutedEventArgs e)
        {
            // Load data when window is fully initialized
            LoadCoursesAndGrades();
        }
        private void LoadCoursesAndGrades()
        {
            if (dx == null) return;
            dx.Courses.Load();
            CourseComboBox.ItemsSource = dx.Courses
                .OrderBy(c => c.Coursecode)
                .Select(c => c.Coursecode)
                .ToList();

            GradeComboBox.ItemsSource = new[] { "A", "B", "C", "D", "E", "F" };
        }

   

        private bool ValidateStudentId(out int studentId)
        {
            studentId = 0;
            if (!int.TryParse(sid.Text, out studentId))
            {
                MessageBox.Show("Invalid Student ID");
                return false;
            }
            return true;
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(sid.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student ID");
                return;
            }

            // Check if ID exists in database
            if (dx.Students.Any(s => s.Id == studentId))
            {
                MessageBox.Show("Student ID already exists in database");
                return;
            }

            // Check if ID is being tracked locally
            var existingStudent = dx.Students.Local.FirstOrDefault(s => s.Id == studentId);
            if (existingStudent != null)
            {
                dx.Entry(existingStudent).State = EntityState.Detached;
            }

            try
            {
                Student s = new()
                {
                    Id = studentId,
                    Studentname = sname.Text,
                    Studentage = int.Parse(sage.Text)
                };

                dx.Students.Add(s);
                dx.SaveChanges();
                MessageBox.Show("Student added successfully");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error adding student: {ex.InnerException?.Message}");
            }
        }

        private void delStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(sid.Text, out int id))
            {
                MessageBox.Show("Invalid Student ID");
                return;
            }

            var student = dx.Students
                .Include(s => s.Grades)  // Important: Include the grades
                .FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                // First remove all grades for this student
                dx.Grades.RemoveRange(student.Grades);

                // Then remove the student
                dx.Students.Remove(student);

                try
                {
                    dx.SaveChanges();
                    MessageBox.Show("Student and associated grades deleted successfully");
                    sname.Text = sage.Text = sid.Text = "";
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"Error deleting student: {ex.InnerException?.Message}");
                }
            }
            else
            {
                MessageBox.Show("Student not found");
            }
        }


        private void updateStudent_Click(object sender, RoutedEventArgs e)
        {

            int id = int.Parse(sid.Text);

            Student s = dx.Students.Where(x => x.Id == id).First();

            if (s != null)
            {
                if (sname.Text.Length > 0) s.Studentname = sname.Text;
                if (sage.Text.Length > 0) s.Studentage = int.Parse(sage.Text);
                dx.SaveChanges();
            }
        }
    }
}
