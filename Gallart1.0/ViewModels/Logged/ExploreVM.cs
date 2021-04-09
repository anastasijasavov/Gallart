using Gallart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gallart.ViewModels.Logged
{
    public class ExploreVM
    {
        public User User { get; set; } // ok        
        public  List<Painting> Paintings { get; set; } // NEPOTREBNO
        public List<List> ListOfLists { get; set; }  // ?????   
        public Painting Painting { get; set; } // 
        public List List { get; set; } // OK
    }
}
