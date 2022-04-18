using DemoContentGit.Entity;

namespace DemoContentGit.Services
{
    public class ProductServices
    {

        public List<Productd> GetAllProduct()
        {
            var list = new List<Product>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(new Product()
                {

                });
            }
            return list;
        }
    }
}
