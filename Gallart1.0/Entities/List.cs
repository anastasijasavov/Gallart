using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gallart.Entities
{
    public class List
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; } // user id foreign key
                                        //many to many veza sa paintings
        //one to many veza:
        [ForeignKey("UserId")]
        public User ParentUser { get; set; }

        public bool isDeleted { get; set; }


        //[ForeignKey("UserId")]
        //public User ParentUser { get; set; }

        //[ForeignKey("PaintingId")]
        //public Painting ParentPainting { get; set; }
            }
}
