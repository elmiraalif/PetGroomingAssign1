using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Owner
    {
        /*
            An owner is someone who owns one or more pets
            Some things that describe an owner:
                - First Name
                - Last Name
                - Address
                - Phone Number (work)
                - Phone Number (home)
              

            An owner must reference a list of pets
            
        */
        [key]
        public int OwnerID { get; set; }
        /* Name of the Owner is a composite attribute containing the attributes below : */
        public string OwnerFName { get; set; }
        public string OwnerLName { get; set; }

        public string OwnerEmail { get; set; }
        public string Ownerphone { get; set; }
        /* Owner has an attribute of address but address is a composite attribute 
         which means it includes other attributes,
         instead of defining OwnerAdress we have these 3 attributes: */
        public string OwnerCity { get; set; }
        public string OwnerStreet { get; set; }
        public string OwnerUnit { get; set; }




    }
}