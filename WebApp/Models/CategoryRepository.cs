namespace WebApp.Models;
public class CategoryRepository :BaseRepository
{
    
    public CategoryRepository(StoreContext context) : base(context)
    {
    }
    public List<Category> GetCategories()
    {
        return context.Categories.ToList();
    }
    public int Add(Category obj)
    {
        context.Categories.Add(obj);
        return context.SaveChanges();
    }
}