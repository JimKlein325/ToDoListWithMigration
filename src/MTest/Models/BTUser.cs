using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MTest.Models
{
    public class BTUser : IdentityUser
    {
        public BTUser()
        {

        }
        public BTUser(string userName) : base(userName)
        {
        }
    }
}
