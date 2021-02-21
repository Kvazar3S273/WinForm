using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeView.Entities
{
    public static class Seeder
    {
        public static void SeedDatabase(EFContext context)
        {
            SeedBreed(context);
        }
        #region Сідимо категорії
        private static void SeedBreed(EFContext context)
        {
            if (context.Breeds.Count() == 0)
            {
                string urlSlug = "seaproducts";
                AddParent(context, urlSlug, "Морепродукти");
                AddChildToParent(context, urlSlug, "fish", "Риба");
                AddChildToParent(context, urlSlug, "tentacles", "Восьминоги");
                AddChildToParent(context, urlSlug, "sponge", "Губки");

                urlSlug = "fish";
                AddChildToParent(context, urlSlug, "mintaj", "Мінтай");
                AddChildToParent(context, urlSlug, "okun", "Окунь");

                urlSlug = "drinkproducts";
                AddParent(context, urlSlug, "Напої");
                AddChildToParent(context, urlSlug, "alcohol", "Алкоголь");
                AddChildToParent(context, urlSlug, "juice", "Соки, води");

                urlSlug = "breadproducts";
                AddParent(context, urlSlug, "Хлібо-булочні вироби");
                AddChildToParent(context, urlSlug, "bread", "Хліб");
                AddChildToParent(context, urlSlug, "baking", "Випічка");

                urlSlug = "meatproducts";
                AddParent(context, urlSlug, "М\'ясо");
                AddChildToParent(context, urlSlug, "sausage", "Ковбасні вироби");
                AddChildToParent(context, urlSlug, "meat", "М\'ясо");
            }
        }
        private static void AddParent(EFContext context, string urlSlug, string name)
        {
            context.Breeds.Add(new Breed
            {
                Name = name,
                ParentId = null,
                UrlSlug = urlSlug
            });
            context.SaveChanges();
        }

        private static void AddChildToParent(EFContext context, string parentSlug, string urlSlug, string name)
        {
            var parent = context.Breeds.SingleOrDefault(x => x.UrlSlug == parentSlug);
            context.Breeds.Add(new Breed
            {
                Name = name,
                ParentId = parent.Id,
                UrlSlug = urlSlug
            });
            context.SaveChanges();
        }
        #endregion
    }
}
