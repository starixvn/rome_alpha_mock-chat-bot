namespace LetstalkMockAPI.Models
{
    public class Payload
    {
        public int type { get; set; }

        public string user_id { get; set; }

        public string receiver { get; set; }

        public int id { get; set; }

        public int time { get; set; }

        public int send_time { get; set; }

        public int due_date { get; set; }

        public int from { get; set; }

        public string hash_content { get; set; }

        public string hash_content_key { get; set; }

        public int hash_id { get; set; }

        public int hash_type { get; set; }
    }
}
