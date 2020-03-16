using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Restaurator.Models
{
    public class Place
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        //public List<string> Images { get; set; }

        public double Rating { get; set; }
    }

}
