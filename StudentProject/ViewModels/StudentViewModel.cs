using CommunityToolkit.Mvvm.ComponentModel;
using StudentProject.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace StudentProject.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student _student;

        [ObservableProperty]
        private List<string> _educationLevels = new EducationLevels().AllEducationLevels;
        private ObservableCollection<string> _educationLevels = new ObservableCollection<string>(new EducationLevels().AllEducationLevels);

        [ObservableProperty]
        private ObservableCollection<Student> _students = new ObservableCollection<Student>(); private ObservableCollection<string> _educationLevels = new ObservableCollection<string>(new EducationLevels().AllEducationLevels);

        [ObservableProperty]
        private ObservableCollection<Student> _students = new ObservableCollection<Student>();

        public StudentViewModel()
        {
            _student = new Student();
        }
    }
}
