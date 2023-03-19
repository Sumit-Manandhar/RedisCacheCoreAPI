namespace RedisCacheCoreAPI.Models
{
    public class ReturnModel
    {
        public bool success { get; set; }
        public string message { get; set; }
        public object data { get; set; }
    }
}
