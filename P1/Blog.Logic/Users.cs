using System;
using System.Xml.Serialization;

namespace Blog.Logic
{
    public abstract class Users
    {
        public string? userName { get; set; }
        public string? email;
        public string? password;
        public string? phoneNumber;
    }
}