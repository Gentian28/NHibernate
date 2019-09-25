using System;
using System.Collections.Generic;
using NHibernateStarter.Models;
using NHibernate;


namespace NHibernateStarter.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void Add(Product product)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(product);
                transaction.Commit();
            }
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetById(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Product GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetByCategory(string category)
        {
            throw new NotImplementedException();
        }
    }
}