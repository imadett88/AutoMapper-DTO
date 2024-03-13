namespace AutoMapperDemo
{
    public class Wallet
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstNameOwner { get; set; } = string.Empty;
        public string LastNameOwner { get; set; } = string.Empty;
        public string Agency { get; set; } = string.Empty;
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }

    }
}
