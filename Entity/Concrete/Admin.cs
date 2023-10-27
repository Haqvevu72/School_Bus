using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Admin : BaseEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
