using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_Rentals.Shared.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
   
        public int Price { get; set; }
    }
}
