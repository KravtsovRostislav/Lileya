using FlowerShop.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlowerShop.EF.SeedData
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder builder)
        {
            SeedCategories(builder.Entity<Category>());
            SeedProducts(builder.Entity<Product>());
            SeedProductsImages(builder.Entity<ProductImage>());
        }

        public static void SeedCategories(EntityTypeBuilder<Category> builder) =>
            builder.HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Кімнатні рослини",
                    Tag = "kimnatni-roslini"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Тюльпани",
                    Tag = "tyulpani"
                });

        public static void SeedProducts(EntityTypeBuilder<Product> builder) =>
            builder.HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Мікс рослин в кашпо",
                    Description = "Мікс рослин у милому керамічному кашпо - чудовий подарунок та знак уваги",
                    Composition = "Мікс рослин у кашпо - 1 на вибір",
                    Size = "XS",
                    Price = 1100,
                    Tag = "miks-roslin-v-kashpo",
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "Висадка в склянній вазі, S",
                    Description = "Висадка міксу рослин у скляній вазі на дерев'яній підставці - додасть затишок та прикрасить інтер'єр",
                    Composition = "Рослини мікс, інтер'єрна ваза",
                    Size = "S",
                    Price = 1550,
                    Tag = "visadka-v-sklyaniy-vazi-s",
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Бонсай в кашпо",
                    Description = "Бонсай оригінальний та незвичайний подарунок для бізнес-партнерів, начальника, колеги, рідних та близьких людей.",
                    Composition = "Бонсай на вибір",
                    Size = "M",
                    Price = 750,
                    Tag = "bonsai-v-kashpo",
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 4,
                    Name = "Сет рослин в керамічному кашпо",
                    Description = "Пропонуємо готовий сет рослин в керамічних кашпо власного виробництва. Рослини не вибагливі у догляді, їм потрібне гарне освітлення та мінімальний полив по мірі засихання ґрунту.",
                    Composition = "Мікс рослин, керамічні кашпо",
                    Size = "XL",
                    Price = 4770,
                    Tag = "set-roslin-v-keramichnomu-kashpo",
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 5,
                    Name = "Заміокулькас, L",
                    Description = "Заміокулькас- багаторічна рослина, яку встигли полюбити за його невибагливість і незвичайний зовнішній вигляд. Народна назва - «Доларове дерево». Родина заміокулькаса - пустельні широти Африки, де воно росте разом з іншими суккулентами - рослинами здатними запасати вологу в м'ясистих стеблах, листках і коренях, яку ці рослини використовують в період посухи.\r\nРослина прекрасно підійде для озеленення Вашого будинку, офісу або закладу. Вічнозелений, невибагливий квітка з легкість пожвавить будь-яке приміщення.\r\n* Ціна рослини вказана без вартості горщика.",
                    Composition = "Заміокулькас; Упаковочний папір",
                    Size = "L",
                    Price = 1380,
                    Tag = "zamiokulkas-l",
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 6,
                    Name = "Букет з 15 ніжних тюльпанів і стіфи",
                    Description = "Букет з міксу ніжних тюльпанів і повітряної стіфи. Букет підкорить своєю легкістю і красою",
                    Composition = "15 тюльпан; Стіфа; Стрічка",
                    Size = "S",
                    Diameter = 25,
                    Height = 35,
                    Price = 1000,
                    Tag = "buket-15-nizhnih-tyulpaniv-i-stify",
                    CategoryId = 2
                },
                new Product()
                {
                    Id = 7,
                    Name = "Букет з 51 білих тюльпанів",
                    Description = "Ніжна хмаринка із 51 білосніжних голландських тюльпанів. Оксамитові та репсові стрічки надають букету особливої ​​романтичності.",
                    Composition = "51 тюльпан, оксамитова та репсова стрічки",
                    Size = "L",
                    Diameter = 35,
                    Height = 35,
                    Price = 2325,
                    Tag = "buket-51-bilyh-tyulpaniv",
                    CategoryId = 2
                },
                new Product()
                {
                    Id = 8,
                    Name = "БУКЕТ З 15 ТЮЛЬПАНІВ БРАУНІ",
                    Description = "Букет з неймовірних голандских тюльпанів сорту Брауні. Ніжку букета прикрашає стрічка в тон",
                    Composition = "15 Тюльпанів Брауні; Стрічка",
                    Size = "S",
                    Diameter = 25,
                    Height = 40,
                    Price = 1530,
                    Tag = "buket-15-tyulpaniv-brauni",
                    CategoryId = 2
                },
                new Product()
                {
                    Id = 9,
                    Name = "БУКЕТ З 25 ФІОЛЕТОВИХ ТЮЛЬПАНІВ ТА ФРЕЗІЇ",
                    Description = "Прекрасний букет з тюльпанів благородного фіолетового кольору та ніжною ароматною фрезією - стане чудовим подарунком для дівчини. Букет прикрашає оксамитова стрічка в тон бутонів",
                    Composition = "5 тюльпанів; Фрезія; Оксамитова стрічка",
                    Size = "M",
                    Diameter = 30,
                    Height = 35,
                    Price = 2035,
                    Tag = "buket-25-phioletovih-tyulpaniv-ta-frezii",
                    CategoryId = 2
                },
                new Product()
                {
                    Id = 10,
                    Name = "БУКЕТ З 51 ТЮЛЬПАНА ТА ПІР'ЯМИ",
                    Description = "Шикарний, ніжний букет з біло-рожевих піоновідних тюльпанів, легкими пір'ями павича та повітряної стіфи. Букет готовий здивувати красою свого одержувача!",
                    Composition = "51 тюльпан, Перо Павича, Стіфа",
                    Size = "L",
                    Diameter = 40,
                    Height = 40,
                    Price = 6710,
                    Tag = "buket-51-tyulpan-ta-pirya",
                    CategoryId = 2
                });

        public static void SeedProductsImages(EntityTypeBuilder<ProductImage> builder) =>
            builder.HasData(
                new ProductImage()
                {
                    Id = 1,
                    ProductId = 1,
                    Uri = "/img/product/prod1.jpg"
                },
                new ProductImage()
                {
                    Id = 2,
                    ProductId = 1,
                    Uri = "/img/product/prod1_preview.jpg"
                },
                new ProductImage()
                {
                    Id = 3,
                    ProductId = 2,
                    Uri = "/img/product/prod2.jpg"
                },
                new ProductImage()
                {
                    Id = 4,
                    ProductId = 2,
                    Uri = "/img/product/prod2_preview.jpg"
                },
                new ProductImage()
                {
                    Id = 5,
                    ProductId = 3,
                    Uri = "/img/product/prod3.jpg"
                },
                new ProductImage()
                {
                    Id = 6,
                    ProductId = 4,
                    Uri = "/img/product/prod4.jpg"
                },
                new ProductImage()
                {
                    Id = 7,
                    ProductId = 5,
                    Uri = "/img/product/prod5.jpg"
                },
                new ProductImage()
                {
                    Id = 8,
                    ProductId = 5,
                    Uri = "/img/product/prod5_preview.jpg"
                },
                new ProductImage()
                {
                    Id = 9,
                    ProductId = 6,
                    Uri = "/img/product/prod6.jpg"
                },
                new ProductImage()
                {
                    Id = 10,
                    ProductId = 6,
                    Uri = "/img/product/prod6_preview.jpg"
                },
                new ProductImage()
                {
                    Id = 11,
                    ProductId = 7,
                    Uri = "/img/product/prod7.jpg"
                },
                new ProductImage()
                {
                    Id = 12,
                    ProductId = 7,
                    Uri = "/img/product/prod7_preview.jpg"
                },
                new ProductImage()
                {
                    Id = 13,
                    ProductId = 8,
                    Uri = "/img/product/prod8.jpg"
                },
                new ProductImage()
                {
                    Id = 14,
                    ProductId = 8,
                    Uri = "/img/product/prod8_preview.jpg"
                },
                new ProductImage()
                {
                    Id = 15,
                    ProductId = 9,
                    Uri = "/img/product/prod9.jpg"
                },
                new ProductImage()
                {
                    Id = 16,
                    ProductId = 9,
                    Uri = "/img/product/prod9_preview.jpg"
                },
                new ProductImage()
                {
                    Id = 17,
                    ProductId = 10,
                    Uri = "/img/product/prod10.jpg"
                },
                new ProductImage()
                {
                    Id = 18,
                    ProductId = 10,
                    Uri = "/img/product/prod10_preview.jpg"
                });
    }
}
