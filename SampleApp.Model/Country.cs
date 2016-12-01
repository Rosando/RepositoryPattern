using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SampleApp.Model
{
    public class Country
    {
        public int CountryID { get; set; }

        [Required]
        [Display(Name = "Country Name")]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual IEnumerable<Person> Persons { get; set; }
    }
}
