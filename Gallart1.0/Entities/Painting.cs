using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gallart.Entities
{
    public class Painting
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Path { get; set; }
        [Required]
        public string Name { get; set; }
       
        public string Genre { get; set; }
        [Required]
        public string Artist { get; set; }

        public string Year { get; set; }

        //public int ListId { get; set; }

        //[ForeignKey("ListId")]
        //public List ParentList { get; set; }


    }
}
