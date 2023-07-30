namespace WebApp.Models;
public abstract class BaseRepository
{
    protected StoreContext  context ;
    public BaseRepository(StoreContext context)
    {
        this.context = context;
    }
}