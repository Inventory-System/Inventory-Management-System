namespace Galaxy.Base.Domain.DAL
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
