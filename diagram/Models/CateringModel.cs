using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace diagram.Models
{
    [DataContract]
    public class CateringModel
    {
        public CateringModel(int x, int y, string label)
        {
            this.x = x;
            this.Y = y;
            this.label = label;
        }
        //private readonly DataContext _context;


        [DataMember(Name = "x")]
        public Nullable<int> x = null;

        [DataMember(Name = "y")]
        public Nullable<int> Y = null;

        [DataMember(Name = "label")]
        public string label = "";

    }
}

