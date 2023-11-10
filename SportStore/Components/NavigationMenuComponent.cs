using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
namespace SportStore.Components
{
    public class NavigationMenuComponent: ViewComponent
    {
        private IStoreRepository repository;
        public NavigationMenuComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
