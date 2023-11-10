using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.ViewModels;


namespace SportStore.Controllers
{
	public class HomeController : Controller
	{
		private IStoreRepository repository;
		public int PageSize = 4;
		public HomeController(IStoreRepository repo)
		{
			repository = repo;
		}

		public IActionResult Index(int productPage = 1)
		{
			return View(new ProductListViewModel { Products =
				repository.Products.OrderBy(p => p.ProductID)
				.Skip((productPage - 1) * PageSize).Take(PageSize),
				PagingInfo = new PagingInfo
				{
					CurrentPage = productPage,
					ItemsPerPage = PageSize,
					TotalItems = repository.Products.Count()
				}
			});

	}

		
	}
}