using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_Rentals.Shared.Domain
{
    public class BicycleModel :BaseDomainModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
