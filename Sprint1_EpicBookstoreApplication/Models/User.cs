using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;

namespace Sprint1_EpicBookstoreApplication.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }    

    }
}
