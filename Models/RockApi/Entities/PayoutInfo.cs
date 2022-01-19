namespace RockApi
{
    public class PayoutInfo : IRockEntity
    {
        public string payoutType { get; set; }
        public bool useDefaultValues { get; set; }
        public string email { get; set; }
    }
}