using Azure;
using LINQassignment.Models;
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
        }

        public Editor(Student s)
        {
            InitializeComponent();
            sname.Text = s.Studentname;
            sid.Text = s.Id.ToString();
            sage.Text = s.Studentage.ToString();
        }

        private void addStudent_Click(object sender, RoutedEventArgs e) {
                
            Student s = new()
            {
                Studentname = sname.Text,
                Studentage = int.Parse(sage.Text),
                Id = int.Parse(sid.Text)
            };

            dx.Students.Add(s);
            dx.SaveChanges();


        
        }

        private void delStudent_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(sid.Text);

            Student s = dx.Students.Where(x => x.Id == id).First();

            if (s != null)
            {
                dx.Students.Remove(s);
                dx.SaveChanges();
            }

            sname.Text = sage.Text = sid.Text = "";
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
