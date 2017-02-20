using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBindingDemo2.Model;

namespace DataBindingDemo2.ViewModel
{
    public class StudentViewModel
    {
        private int ID = 1000;
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            // lisätään esimerkin vuoksi muutama opiskelija, oikeassa sovelluksessa haettaisiin tietokannasta
            students.Add(new Student { FirstName = "Kalle", LastName = "Jalkanen", AsioId = "A" + ID++ });
            students.Add(new Student { FirstName = "Teppo", LastName = "Testaaja", AsioId = "A" + ID++ });
            students.Add(new Student { FirstName = "Tomi", LastName = "Töttenström", AsioId = "A" + ID++ });
            Students = students;
        }
    }
}
