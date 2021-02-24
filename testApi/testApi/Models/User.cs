using System;
using System.Collections.Generic;
using System.Text;

namespace testApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is User user))
            {
                return false;
            }

            return Id == user.Id && Name == user.Name && Username == user.Username && Email == user.Email && Address.Equals(user.Address);
        }
    }
}
