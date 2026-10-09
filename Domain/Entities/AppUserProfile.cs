using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class AppUserProfile:BaseEntity
    {
        public int AppUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties

        public virtual AppUser AppUser { get; set; }
    }
}
