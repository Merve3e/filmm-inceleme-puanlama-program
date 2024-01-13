using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExchangeConsoleApp.models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Phone {  get; set; }

        public User(){}

        public User(int id, string name, string surname, string email, string password, string confirmPassword, string phone)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
            Phone = phone;
        }


    }
}
