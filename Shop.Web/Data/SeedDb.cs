namespace Shop.Web.Data
{

    using Entities;
    using Helpers;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private readonly Random random;


        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();
        }


        public async Task SeedAsync()
        {
            //espera que se cree la base de datos
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmailAsync("dannygaviria111@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Danny",
                    LastName = "Gaviria",
                    Email = "dannygaviria111@gmail.com",
                    UserName = "dannygaviria111@gmail.com",
                    PhoneNumber = "3196566541"

                };

                var result = await this.userHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

            if (!this.context.Products.Any())
            {
                this.AddProduct("iPhone x", user);
                this.AddProduct("Magic Mouse", user);
                this.AddProduct("iWatch Series 4", user);
                await this.context.SaveChangesAsync();
            }
        }




        private void AddProduct(string name, User user)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Price = this.random.Next(100),
                IsAvailabe = true,
                Stock = this.random.Next(100),
                User = user
            });
        }
    }
}