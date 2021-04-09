using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gallart.Entities
{
    public class ListToPainting
    {
        [Key]
        public int Id { get; set; }
        public int ListId { get; set; }
        public int PaintingId { get; set; }


        [ForeignKey("ListId")]
        public List ParentList { get; set; }

        [ForeignKey("PaintingId")]
        public Painting ParentPainting { get; set; }
    }
}
