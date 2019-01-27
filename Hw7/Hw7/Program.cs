using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ShopContext())
            {
                Category category = new Category
                {
                    Name = "vegetables"
                };

                var user = new User
                {
                    Login = "vadim",
                    Password = "password"
                };

                var cart = new Cart
                {

                };

                user.Cart = cart;

                var item = new Product
                {
                    Name = "Carrot",
                    Price = 150
                };

                item.Category = category;

                cart.Items = new List<Product>
                {
                    item
                };

                context.Carts.Add(cart);
                context.Users.Add(user);
                context.Products.Add(item);

                context.SaveChanges();
            }
        }
    }
}
