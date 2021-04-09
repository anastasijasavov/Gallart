using Gallart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gallart.ViewModels.Logged
{
    public class PaintingVM
    {
        public int Id { get; set; }
       public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }
        public string Path { get; set; }
    }
}
