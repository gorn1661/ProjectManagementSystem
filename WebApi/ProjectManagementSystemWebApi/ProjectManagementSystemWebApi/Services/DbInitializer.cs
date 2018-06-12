using ProjectManagementSystemWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystemWebApi.Services
{
    public static class DbInitializer
    {
        public static void Initialize(ProjectManagementSystemDbContext _context)
        {

            if (_context.Project.Any())
            {
                return;
            }

            var customers = new Customer[]
            {
                    new Customer{FirstName = "Adam", LastName = "Nowak", CompanyName="Diet System Company", NIP="18492793019", Email="nowakA@ctmw.pl", Phone="+48345198429"},
                    new Customer{FirstName = "Grażyna", LastName = "Olchowik", Email="GO12031991@gmail.com", Phone="+44738987219"},
            };

            _context.Customer.AddRange(customers);
            _context.SaveChanges();

            var employees = new Employee[]
            {
                    new Employee{FirstName = "John", LastName="Goldenwick", Email="jhonny@gmail.com", PhoneNumber="+12673549074"},
                    new Employee{FirstName = "Bogdan", LastName="Jaworski", Email="jawor@gmail.com", NIP="83506209659", PhoneNumber="+48735016009"},
                    new Employee{FirstName = "Нюша", LastName="Сатю", Email="nyusha@gmail.com", PhoneNumber="+7348567209"},
            };

            _context.Employee.AddRange(employees);
            _context.SaveChanges();

            var projects = new Project[]
            {
                new Project{Name="Advertising campaign for ITServicesInternational", Description="Creating WebPage with offer and blog from DB, logo and business card. To discuss with ITServices manager.", StartDate=new DateTime(2018, 06, 01, 10, 00, 00), Customer = customers.Single(d => d.FirstName == "Adam")},
                new Project{Name="Web application for DietSystemCompany", Description="Creating WebPage with WebApi. All content the Company give us later.", StartDate=new DateTime(2018, 06, 20, 08, 30, 00), Customer = customers.Single(d => d.FirstName == "Grażyna")},
                new Project{Name="Garden system for PsikankaPoland", Description="Creating WebPage with WebApi and devices based on arduino with phisical system. All details later.", StartDate=new DateTime(2018, 08, 10, 18, 00, 00), Customer = customers.Single(d => d.FirstName == "Grażyna")},
                new Project{Name="BMW Car Configurator Optimization", Description="For better working on mobile devices. Seriously", StartDate=new DateTime(2018, 11, 25, 16, 00, 00), Customer = customers.Single(d => d.FirstName == "Adam")},
            };

            _context.Project.AddRange(projects);
            _context.SaveChanges();

            var employeeProjects = new EmployeeProject[]
            {
                    new EmployeeProject{Employee = employees.Single(d => d.FirstName == "John"), Project = projects.Single(d => d.Name == "Advertising campaign for ITServicesInternational")},
                    new EmployeeProject{Employee = employees.Single(d => d.FirstName == "Bogdan"), Project = projects.Single(d => d.Name == "Advertising campaign for ITServicesInternational")},
                    new EmployeeProject{Employee = employees.Single(e => e.FirstName == "Нюша"), Project = projects.Single(d => d.Name == "Advertising campaign for ITServicesInternational")},
            };

            _context.EmployeeProject.AddRange(employeeProjects);
            _context.SaveChanges();

          
        }
    }
}
