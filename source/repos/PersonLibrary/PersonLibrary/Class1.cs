using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PersonLibrary
{
    //Многофайловая сборка
    public class Person
    {
        public string Name;
        public string Surname;
        public int Age;

        public Person() { 
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void AboutPerson()
        {

            MessageBox.Show("Surname -" + Surname + ", Name - " + Name + ", Age - " + Age);
        }

    }
}
