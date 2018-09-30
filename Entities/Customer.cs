namespace Entities
{
    public class Customer : BaseEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public int Age { get; set; }
        public string SocialStatus { get; set; }
        public string Gender { get; set; }
    }
}