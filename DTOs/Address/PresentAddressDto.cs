﻿namespace EfCoreRelation.DTOs.Address
{
    public class PresentAddressDto
    {
        public int Id { get; set; }
        public string Village { get; set; }
        public string PostOffice { get; set; }
        public string PoliceStation { get; set; }
        public string District { get; set; }
        public int EmployeeAddressId { get; set; }
    }
}
