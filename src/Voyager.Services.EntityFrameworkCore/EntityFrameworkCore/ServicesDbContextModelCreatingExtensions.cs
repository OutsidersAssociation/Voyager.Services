using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Voyager.Services.EntityFrameworkCore
{
    public static class ServicesDbContextModelCreatingExtensions
    {
        public static void ConfigureServices(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ServicesConsts.DbTablePrefix + "YourEntities", ServicesConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}