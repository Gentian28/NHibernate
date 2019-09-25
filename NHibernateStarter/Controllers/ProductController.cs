using NHibernateStarter.Models;
using NHibernateStarter.Repositories;
using System.Web.Http;

namespace NHibernateStarter.Controllers
{
    public class ProductController : ApiController
    {
        // POST api/values
        public void Post([FromBody]string value)
        {
            var product = new Product { Name = "Apple", Category = "Fruits" };
            IProductRepository repository = new ProductRepository();
            repository.Add(product);
        }       
    }
}
