using Assignment2.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Seed Categories
            modelBuilder.Entity<Category>().HasData(
                    new Category()
                    {
                        ID = 1,
                        Name = "Samsung"
                    },
                    new Category()
                    {
                        ID = 2,
                        Name = "Apple"
                    },
                    new Category()
                    {
                        ID = 3,
                        Name = "Nokia"
                    }
                );
            #endregion
        }
    }
}
