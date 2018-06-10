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
                return;
            var projects = new Project[]
            {
                new Project{Name="Advertising campaign for ITServicesInternational", Description="Creating WebPage with offer and blog from DB, logo and business card. To discuss with ITServices manager.", StartDate=new DateTime(2018, 06, 01, 10, 00, 00)},
                new Project{Name="Web application for DietSystemCompany", Description="Creating WebPage with WebApi. All content the Company give us later.", StartDate=new DateTime(2018, 06, 20, 08, 30, 00)},
                new Project{Name="Garden system for PsikankaPoland", Description="Creating WebPage with WebApi and devices based on arduino with phisical system. All details later.", StartDate=new DateTime(2018, 08, 10, 18, 00, 00)},
                new Project{Name="BMW Car Configurator Optimization", Description="For better working on mobile devices. Seriously", StartDate=new DateTime(2018, 11, 25, 16, 00, 00)},
            };

            _context.Project.AddRange(projects);
            _context.SaveChanges();
        }
    }
}
