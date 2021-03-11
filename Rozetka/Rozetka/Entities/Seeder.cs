using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozetka.Entities
{
    public class Seeder
    {
        public static void SeedDatabase(EFContext context)
        {
            SeedFilter(context);
        }
        
        #region Filters

        private static void SeedFilter(EFContext context)
        {
            #region tblFilterNames - Назви фільтрів

            string[] filterNames = { "Виробник", "Потужність" };
            foreach (var type in filterNames)
            {
                if (context.FilterNames.SingleOrDefault(f => f.Name == type) == null)
                {
                    context.FilterNames.Add(
                        new FilterName
                        {
                            Name = type
                        });
                    context.SaveChanges();
                }
            }
            #endregion

            #region tblFilterValues - Значення фільтрів

            List<string[]> filterValues = new List<string[]>
            {
                new string[]{"Bosch","Makita","Metabo","Zenit","Intertool"},
                new string[]{"550","700","900","1200"}
            };
            foreach (var items in filterValues)
            {
                foreach (var value in items)
                {
                    if (context.FilterValues
                        .SingleOrDefault(f => f.Name == value) == null)
                    {
                        context.FilterValues.Add(
                            new FilterValue
                            {
                                Name = value
                            });
                        context.SaveChanges();
                    }
                }
            }
            #endregion

            #region Групування фільтрів
            for (int i = 0; i < filterNames.Length; i++)
            {
                foreach (var value in filterValues[i])
                {
                    var nId = context.FilterNames
                        .SingleOrDefault(ben => ben.Name == filterNames[i]).Id;
                    var vId = context.FilterValues
                        .SingleOrDefault(f => f.Name == value).Id;
                    if (context.FilterNameGroups
                        .SingleOrDefault(f => f.FilterValueId == vId &&
                        f.FilterNameId == nId) == null)
                    {
                        context.FilterNameGroups.Add(
                            new FilterNameGroup
                            {
                                FilterNameId = nId,
                                FilterValueId = vId
                            });
                        context.SaveChanges();
                    }
                }
            }
            #endregion

            #region Add products
            List<string> unique = new List<string>()
            {"GAL18V",
            "GSR18V",
            "4350FCT",
            "KHE2644",
            "ЗУШ-180",
            "ET-7145"
            };

            
            if (context.Products.SingleOrDefault(f => f.UniqueName == unique[0]) == null)
                context.Products.Add(
                        new Product
                        {
                            UniqueName = unique[0],
                            Price = 3899,
                            Image = "https://i8.rozetka.ua/goods/21815291/57326361_images_21815291593.jpg",
                            Name = "Акумуляторна дриль-шуруповерт Bosch Professional GSR 180-Li"
                        });

            if (context.Products.SingleOrDefault(f => f.UniqueName == unique[1]) == null)
                context.Products.Add(
                        new Product
                        {
                            UniqueName = unique[1],
                            Price = 6499,
                            Image = "https://i8.rozetka.ua/goods/20348972/255821981_images_20348972081.jpg",
                            Name = "Акумуляторна дриль-шуруповерт Bosch Professional GSR 18 V-50"
                        });

            if (context.Products.SingleOrDefault(f => f.UniqueName == unique[2]) == null)
                context.Products.Add(
                        new Product
                        {
                            UniqueName = unique[2],
                            Price = 320,
                            Image = "https://i1.rozetka.ua/goods/5954/makita_4350fct_images_5954716.jpg",
                            Name = "Електролобзик Makita 4350FCT"
                        });

            if (context.Products.SingleOrDefault(f => f.UniqueName == unique[3]) == null)
                context.Products.Add(
                        new Product
                        {
                            UniqueName = unique[3],
                            Price = 4099,
                            Image = "https://i8.rozetka.ua/goods/20872643/metabo_khe_2644_images_20872643441.jpg",
                            Name = "Перфоратор Metabo KHE 2644"
                        });
            if (context.Products.SingleOrDefault(f => f.UniqueName == unique[4]) == null)
                context.Products.Add(
                        new Product
                        {
                            UniqueName = unique[4],
                            Price = 2066,
                            Image = "https://i1.rozetka.ua/goods/2066842/zenit_832184_images_2066842561.jpg",
                            Name = "Кутова шліфмашина Зенит Профи ЗУШ-180/2200"
                        });
            if (context.Products.SingleOrDefault(f => f.UniqueName == unique[5]) == null)
                context.Products.Add(
                        new Product
                        {
                            UniqueName = unique[5],
                            Price = 3824,
                            Image = "https://i2.rozetka.ua/goods/1427503/intertool_et_7145_images_1427503227.jpg",
                            Name = "Професійний набір інструментів Intertool"
                        });
            context.SaveChanges();
            #endregion

            #region Filters
            Filter[] filters =
            {
                new Filter { FilterNameId = 1, FilterValueId = 1, ProductId = 1},
                new Filter { FilterNameId = 2, FilterValueId = 9, ProductId = 1},

                new Filter { FilterNameId = 1, FilterValueId = 1, ProductId = 2},
                new Filter { FilterNameId = 2, FilterValueId = 10, ProductId = 2},

                new Filter { FilterNameId = 1, FilterValueId = 2, ProductId = 3},
                new Filter { FilterNameId = 2, FilterValueId = 8, ProductId = 3},

                new Filter { FilterNameId = 1, FilterValueId = 3, ProductId = 4},
                new Filter { FilterNameId = 2, FilterValueId = 7, ProductId = 4},

                new Filter { FilterNameId = 1, FilterValueId = 4, ProductId = 5},
                new Filter { FilterNameId = 2, FilterValueId = 11, ProductId = 5},

                new Filter { FilterNameId = 1, FilterValueId = 5, ProductId = 6},
                new Filter { FilterNameId = 2, FilterValueId = 14, ProductId = 6},
            };
            foreach (var item in filters)
            {
                var f = context.Filters.SingleOrDefault(p => p == item);
                if (f == null)
                {
                    context.Filters.Add(new Filter { FilterNameId = item.FilterNameId, FilterValueId = item.FilterValueId, ProductId = item.ProductId });
                    context.SaveChanges();
                }
            }
            #endregion
        }



        #endregion
    }
}
