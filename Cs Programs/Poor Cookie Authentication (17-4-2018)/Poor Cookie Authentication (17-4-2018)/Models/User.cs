using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poor_Cookie_Authentication__17_4_2018_.Models
{
    public class User
    {
        public static User[] Users { get; } =
            new[]
            {
                new User() { Username = "ebrown@example.com", Password = "1234" },
                new User() { Username = "johndoe@example.com", Password = "5678" }
            };

        public string Username { get; private set; }
        public string Password { get; private set; }
    }
}