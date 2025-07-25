using System.Numerics;

namespace HRS.Models.Entities
{
    public class LK_Specialties
    {
        public int Id { get; set; }
        public string SpecialtyName { get; set; }
        public string? SpecialtyCode { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
     
        public Doctor Doctor { get; set; }
    }
}
