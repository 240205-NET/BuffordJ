using System;
using System.Xml.Serialization;

namespace Blog.Logic
{
    public class Authors : Users
    {
        // Fields
        public string? name { get; set; }
        public double? rating { get; set; } = 0;

        // Constructor
        public Authors()
        {}

        public Authors(string name, double rating, string userName, string email, string password, string phoneNumber)
        {
            this.name = name;
            this.rating = rating;
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
        }

        // Methods
        
        public override string ToString()
        {
            return $"---------- Author ----------\nName: {this.name}\nRating: {this.rating}\nUsername: {this.userName}\nEmail: {this.email}\nPhone Number: {this.phoneNumber}\n";
        }
    }
}