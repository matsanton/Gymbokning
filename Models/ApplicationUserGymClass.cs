using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymbokning.Models
{
    public class ApplicationUserGymClass
    {
        public int GymClassId { get; set; }
        public string ApplicationUserId { get; set; } // så är det implementerat default, att använda string som nyckel

        //Navigation property
        public GymClass GymClass { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
