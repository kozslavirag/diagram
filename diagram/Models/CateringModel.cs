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
        public CateringModel(int Date, int SalesVolume)
        {
            this.Date = Date;
            this.SalesVolume = SalesVolume;

        }
        //private readonly DataContext _context;


        [DataMember(Name = "Date")]
        public Nullable<int> Date = null;

        [DataMember(Name = "SalesVolume")]
        public Nullable<int> SalesVolume = null;



    }
}

