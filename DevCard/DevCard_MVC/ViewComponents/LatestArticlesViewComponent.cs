using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace DevCard_MVC.ViewComponents
{
	
	public class LatestArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var Article = new List<Article>
			{
				new Article (  1,  "Asp.net core MVC", "پکیج اموزشی به زبان فارسی" , "blog-post-thumb-card-1.jpg" ),
				new Article (  2,  "Git & Github", "پکیج اموزشی به زبان فارسی" , "blog-post-thumb-card-2.jpg" ),
				new Article (  3,  "Onion Arcitecture", "پکیج اموزشی به زبان فارسی" , "blog-post-thumb-card-3.jpg" ),
				new Article (  4,  "Ui/UX", "پکیج اموزشی به زبان فارسی" , "blog-post-thumb-card-4.jpg" )
				
			};
			return View("_LatestArticles", Article);
		}
	}
}
