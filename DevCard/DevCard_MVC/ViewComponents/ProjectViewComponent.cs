using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            var projects = new List<Project>
            { 
                
                new Project(1,"تاکسی","درخواست آنلاین تاکسی","project-1.jpg","Snapp"),
                new Project(2,"زود فود","درخواست آنلاین غذا در سرار کشور","project-2.jpg","Snapp Food"),
                new Project(3,"مدارس","سیستم مدیرت یکپارچه مدارس","project-3.jpg", "MONOP"),
				new Project(4,"فضا پیما","برنامه مدیریت فضاپیماهای ناسا","project-4.jpg", "Nasa"),

			};
            return View("Projects",projects);
        }
    }
}
