using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VIPStore.Models
{
    public class EFStoreRepositoryc : IStoreRepository
    {
        private StoreDbContext context;

        public EFStoreRepositoryc(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
