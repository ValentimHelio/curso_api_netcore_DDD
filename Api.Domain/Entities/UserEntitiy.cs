using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class UserEntitiy : BaseEntity
    {
        public string name { get; set; }    
        public string email { get; set; }
    }
}
