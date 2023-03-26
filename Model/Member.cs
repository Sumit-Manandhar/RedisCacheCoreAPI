namespace RedisCacheCoreAPI.Models
{
    public class Member
    {
        public int MemberId { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public int? CountryID { get; set; }

        public string? Phone { get; set; }
    }
}
