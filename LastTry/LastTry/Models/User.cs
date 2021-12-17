using System;

namespace LastTry.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Speciality { get; set; }
        public int Password { get; set; }
    }
}