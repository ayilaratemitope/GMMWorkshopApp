namespace GMMWorkshopApp.Models
{
    public class ClassAttendance
    {
        public int Id { get; set; }

        public int MotoristId { get; set; }
        public Motorist? Motorist { get; set; }

        public int ClassSessionId { get; set; }
        public ClassSessions? ClassSession { get; set; }

        public DateTime AttendanceDate { get; set; }

    }
}
