using EmployeeManagement.Model;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Components.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }
        private void LoadEmployees()
        {
            Thread.Sleep(3000);
            //Please rever the collection Employees and fill it with dummy data need 5 Employee
            Employees =
            [
                new Employee
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    DateOfBirth = new DateTime(1990, 5, 15),
                    //Department = "IT",
                    PhotoPath = "john_doe.jpg"
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    DateOfBirth = new DateTime(1985, 10, 20),
                    //Department = "Marketing",
                    PhotoPath = "jane_smith.jpg"
                },
                // Add more employees as needed
            ];

        }
    }
}
