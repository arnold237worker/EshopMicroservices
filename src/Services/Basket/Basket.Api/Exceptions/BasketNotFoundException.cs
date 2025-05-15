namespace Basket.Api.Exceptions
{
    public class BasketNotFoundException : NotFoundException
    {
        public BasketNotFoundException(string name) : base("Basket", name)
        {
        }
    }
}
