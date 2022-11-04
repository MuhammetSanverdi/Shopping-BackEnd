using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CargoInformation:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Countries Country { get; set; }
        public string RecipientFirstName { get; set; }
        public string RecipientLastName { get; set; }
        public string Address { get; set; }
    }
}
