using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SampleApp.Model
{
    [Table("Person")]
    public class Person
    {
        public long PersonID { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string State { get; set; }

        [Display(Name="Country")]
        public int CountryID { get; set; }

        [ForeignKey("CountryID")]
        public virtual Country Country { get; set; }
    }
}
