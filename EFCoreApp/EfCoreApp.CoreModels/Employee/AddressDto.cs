using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreApp.CoreModels.Employee
{
    public class AddressDto
    {
        public Guid AddressId { get; set; }
        public Guid EmployeeId { get; set; }
        public string HouseNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
    }
}
