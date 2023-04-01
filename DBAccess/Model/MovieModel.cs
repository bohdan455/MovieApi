using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Model
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Released { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
    }
}
