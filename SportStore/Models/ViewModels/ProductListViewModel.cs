namespace SportStore.Models.ViewModels
{
	public class ProductListViewModel
	{
		 public IEnumerable<Product> Products { get; set; }
			=Enumerable.Empty<Product>();
		public string? CurrentCategory { get; set; }
		public PagingInfo PagingInfo { get; set; } = new();
	}
}
