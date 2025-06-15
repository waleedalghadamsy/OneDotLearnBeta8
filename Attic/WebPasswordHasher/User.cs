namespace WebPasswordHasher
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string OriginalPassword { get; set; }
        public string HashedPassword { get; set; }
    }
}
