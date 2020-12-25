using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaticFiles.Models
{
    public class IndexModel
    {
        [Required(ErrorMessage ="ID is required")]
        public int ID { get; set; }
        
        public string Message { get; set; }
    }
}
