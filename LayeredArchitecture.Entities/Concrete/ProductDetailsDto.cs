using LayeredArchitecture.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Entities.Concrete
{
    public class ProductDetailsDto: IDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public short UnitsInStock { get; set; }
    }
}
