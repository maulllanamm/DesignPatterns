using DesignPatternServices_.CreationalPatterns.Prototype.Interface_Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.Prototype.Concrete_Prototype
{
    public class EmployeeProfile : IEmployeePrototype
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public decimal Salary { get; set; }
        public IEmployeePrototype Clone()
        {
            return new EmployeeProfile
            {
                Name = this.Name,
                Address = this.Address,
                Role = this.Role,
                Salary = this.Salary
            };
        }

        public string DisplayProfile()
        {
            return $"Name: {Name} | Address: {Address} | Role: {Role} | Salary: ${Salary}";
        }
    }
}
