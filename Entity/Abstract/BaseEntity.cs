using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Abstract
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public BaseEntity()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
    }
}
