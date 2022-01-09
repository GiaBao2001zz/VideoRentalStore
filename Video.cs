using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalStore
{
    class Video
    {
        public string id { get; set; }
        public string Name { get; set; }

        public float Price { get; set; }

        public int Quantity { get; set; }

        public string Director { get; set; }

        public string Actor { get; set; }

        public string Decription { get; set; }
        public string Thumbnail { get; set; }
        public string Provider { get; set; }
        public string Category { get; set; }
    }
}
