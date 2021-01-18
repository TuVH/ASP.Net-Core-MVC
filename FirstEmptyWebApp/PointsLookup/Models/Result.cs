using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PointsLookup.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        public string IdentNumber { get; set; }
        public double MathScores { get; set; }
        public double EnglishScores { get; set; }
        public double LiteratureScores { get; set; }
        public double ChemiscalScores { get; set; }
        public double PhysicalScores { get; set; }
        public double BiologicalScores { get; set; }

        public int Year { get; set; }

        //Khóa Ngoại CMND tham chiếu tới bảng Student theo quy tắc one to many
        public string CMND_Student { get; set; }
        public Student Student { get; set; }
    }
}