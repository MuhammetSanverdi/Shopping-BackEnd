using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SuitId { get; set; }
        public string BusinessAddress { get; set; }
        public string StorageAddress { get; set; }
    }
}
