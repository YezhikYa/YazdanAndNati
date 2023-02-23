using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Friend
    {
        private int id;
        private string family;
        private string name;
        private DateTime birthDate;
        private string phone;
        private string email;
        private string password;
        private string picture;

        public Friend() {}

        public int Id { get => id; set => id = value; }
        public string Family { get => family; set => family = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Picture { get => picture; set => picture = value; }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - birthDate.Year;
                if (birthDate > now.AddYears(-age))
                    age--;

                return age;
            }
        }
        public string FullName
        {
            get { return family + " " + name; }
        }

        public override bool Equals(object obj)
        {
            return obj is Friend friend &&
                   id == friend.id &&
                   family == friend.family &&
                   name == friend.name &&
                   birthDate == friend.birthDate &&
                   phone == friend.phone &&
                   email == friend.email &&
                   password == friend.password &&
                   picture == friend.picture;
        }

        public static bool operator ==(Friend left, Friend right)
        {
            return EqualityComparer<Friend>.Default.Equals(left, right);
        }

        public static bool operator !=(Friend left, Friend right)
        {
            return !(left == right);
        }
    }
}
