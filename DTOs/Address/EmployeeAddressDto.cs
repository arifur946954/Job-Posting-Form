using EfCoreRelation.Entity.Address;

namespace EfCoreRelation.DTOs.Address
{
    public class EmployeeAddressDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
    
        public List<PresentAddressDto> presentAddresses { get; set; }
        public List<ParmanentAddressDto> parmanentAddresses { get; set; }
    }
}
