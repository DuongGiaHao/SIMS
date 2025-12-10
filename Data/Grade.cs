namespace SIMS.Data
{
    public class Grade
    {
        public int Id { get; set; }
        public int EnrollmentId { get; set; }
        public Enrollment Enrollment { get; set; }
        public decimal? MidtermScore { get; set; }
        public decimal? FinalScore { get; set; }
        public decimal? TotalScore { get; set; }
        public string? LetterGrade { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
