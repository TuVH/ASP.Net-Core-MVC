using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PointsLookup.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng không bỏ trống số báo danh")]
        public string IdentNumber { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double MathScores { get; set; }
        public double EnglishScores { get; set; }
        public double LiteratureScores { get; set; }
        public double ChemiscalScores { get; set; }
        public double PhysicalScores { get; set; }
        public double BiologicalScores { get; set; }
    }
}
