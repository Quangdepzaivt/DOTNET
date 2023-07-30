namespace WebApp.Models;
public class BrandRepository
{
    StoreContext context;
    public BrandRepository(StoreContext context){
        this.context = context;
    }
    public List<Brand> GetBrands(){
        return context.Brands.ToList();
    }
}