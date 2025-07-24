namespace HRS.Models.Entities
{
    public class lK_UserType
    {
        public int Id { get; set; }
        public string UserTypeName { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<User> User { get; set; } = [];
    }
}
