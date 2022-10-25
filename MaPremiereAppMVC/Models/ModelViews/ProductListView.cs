namespace MaPremiereAppMVC.Models.ModelViews
{
    public class ProductListView
    {
        public List<Product> Products { get; set; }
        public int NbProductsTotal { get => Products?.Count ?? 0; }
        public int NbProductsInStock { get => Products?.Where(p=>p.Stock>0).Count() ?? 0; }
    }
}
