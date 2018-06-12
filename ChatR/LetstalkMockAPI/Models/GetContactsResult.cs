using System.Collections.Generic;

namespace LetstalkMockAPI.Models
{
    public class GetContactsResult : Result
    {
        public string tag { get; set; }

        public IEnumerable<Contact> Contacts { get; set; }
    }
}
