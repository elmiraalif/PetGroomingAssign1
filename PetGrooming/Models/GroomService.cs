using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomService
    {
        /*
            A GroomService is a type of activity that a Groomer can do for a pet. Some examples might be nail clipping, shampoo, trim, etc.
            
            Some things that describe a GroomService
                - Service Name
                - Cost
                - Duration
         */
            [key]
            public int ServiceID { get; set; }
            public string ServiceName { get; set; }
            /*The duration is going to be stored in MINUTES (ex. 1.5 hr  = 90 min) */
            public int ServiceDuration { get; set; }
            /*The cost is going to be stored in CENTS (ex. $20  = 2000 cents) */
            public int ServiceCost { get; set; }

    }
}