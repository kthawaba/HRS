namespace HRS.Models.ViewModels
{
    public class LK_SpecialtiesModel
    {
        public int Id { get; set; }
        public string SpecialtyName { get; set; }
        public string? SpecialtyCode { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
