using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Data.Models
{
    public class ShopCart
    {
        private readonly AppDbContext appDBContent;

        public ShopCart(AppDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string JerseyViewId { get; set; }
        public List<JerseyItem> listJerseyItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { JerseyViewId = shopCartId };
        }

        public void AddToCart(Jersey jersey)
        {
            appDBContent.JerseyItem.Add(new JerseyItem
            {
                JerseyViewId = JerseyViewId, 
                jersey = jersey,
                price = jersey.price
            });

            appDBContent.SaveChanges();
        }

        public List<JerseyItem> getJerseyItems()
        {
            return appDBContent.JerseyItem.Where(c => c.JerseyViewId == JerseyViewId).Include(s => s.jersey).ToList();
        }
    }
}
