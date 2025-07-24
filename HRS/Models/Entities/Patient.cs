namespace HRS.Models.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
