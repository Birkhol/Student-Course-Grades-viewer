using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Navigation;

namespace LINQassignment.Models;

public partial class Student : INotifyPropertyChanged
{
    public int Id { get; set; }

    private string name = null!;

    public string Studentname
    {
        get => name;
        set
        {
            name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Studentname)));
        }
    }

    public int Studentage { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public event PropertyChangedEventHandler? PropertyChanged;
}
