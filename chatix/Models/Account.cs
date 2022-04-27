using System.Security.Cryptography;

namespace chatix.Models
{
    public class Account
    {
        private string password;
        public int ID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { 
            get { return password; }
            set { password = SHA256.Create() } 
        }
    }
}
