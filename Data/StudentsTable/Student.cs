using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RDLCReports.Data.StudentsTable
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [NotNull]
        public string StudentName { get; set; }
        [NotNull]
        public int Standard { get; set; }
        [NotNull]
        public string Address { get; set; }

    }
}
