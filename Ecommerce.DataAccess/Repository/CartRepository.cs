using Ecommerce.DataAccess;
using Ecommerce.DataAccess.Repository;
using Ecommerce.Models.Models;
using Ecommerce.Repository.IRepository;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository.Repository
{
   

    public class CartRepository : Repository<Cart>, ICartRepository
        {
            


            private readonly ApplicationDbContext DbContext;

            public CartRepository(ApplicationDbContext dbContext) : base(dbContext)
            {
                DbContext = dbContext;
            }

            public Cart Update(Cart obj)
            {
                var cart = DbContext.Carts.FirstOrDefault(u => u.Id == obj.Id);
                if (cart != null)
                {
                    cart.Id = obj.Id;
                    cart.UserId = obj.UserId;
                    cart.ItemId = obj.ItemId;

                }
                return cart;
            }

        }
    }



       
       
