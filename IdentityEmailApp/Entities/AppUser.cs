using Microsoft.AspNetCore.Identity;

namespace IdentityEmailApp.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string?  ImageUrl{ get; set; }
        public ICollection<Message>  SentMessages { get; set; }
        public ICollection<Message>  ReceivedMessages { get; set; }

    }
}
