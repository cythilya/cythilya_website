﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cythilya.Areas.EShopper.Models;

namespace cythilya.Areas.EShopper.Controllers
{
    public class HomeController : Controller
    {
        MvcShoppingContext db = new MvcShoppingContext();

        #region View

        //首頁
        public ActionResult Index()
        {
            GetCategotyList();//取得商品類別
            GetCarouselList();//取得輪播資料
            GetFeaturedProductList();//取得特色商品列表
            GetCategoryProduct();//取得特定類別的商品
            GetMainTagList();//取得主要標籤列表
            GetTaggableProduct();//取得特定標籤的商品列表
            GetRecommendItemsList();//取得推薦商品列表
            //GetAllProducts();//取得所有商品
            return View();
        }

        //商品列表
        public ActionResult Category(int ID = 0)
        {
            GetCategotyList();//取得商品類別
            GetCategoryProduct(ID);//取得特定類別的商品
            GetCategoryInfo(ID);//取得類別資訊
            return View();
        }

        //商品明細
        public ActionResult Product(int ID = 0)
        {
            GetCategotyList();//取得商品類別
            GetProductDetail();//取得特定商品資訊
            GetRecommendItemsList();//取得推薦商品列表
            GetMainTagList();//取得主要標籤列表
            GetTaggableProduct();//取得特定標籤的商品列表
            return View();
        }

        //404
        public ActionResult NotFound()
        {
            return View();
        }

        //Contact
        public ActionResult Contact()
        {
            return View();
        }

        #endregion

        #region Function

        //取得商品類別
        void GetCategotyList()
        {
            var dbData = db.ProductCategories.ToList();
            ViewBag.CategoryList = dbData;
        }

        //取得類別資訊
        void GetCategoryInfo(int ID = 0)
        {
            var category = db.ProductCategories.Find(ID);
            ViewBag.CategoryName = category.Name;
            ViewBag.CategoryPicUrl = category.PicUrl;
        }

        //取得特定類別的商品
        void GetCategoryProduct(int ID = 0)
        {
            #region fake data - product
            var productCategory = new ProductCategory() { ID = 1, Name = "WOMENS" };

            var tag = new Tag() { ID = 1, Name = "New Arrival" };
            var tagList = new List<Tag>();
            tagList.Add(tag);

            var ProductList = new List<Product>()
            {
                new Product()
                {
                    ID = 1, 
                    Name = "Easy Polo Black Edition",
                    ProductCategory = productCategory,
                    Description = "",
                    RawPicUrl = "",
                    PicLargeUrl = "",
                    PicMediumUrl = "http://dummyimage.com/268x249/000/fff",
                    PicSmallUrl = "",
                    PicFeaturedUrl = "http://dummyimage.com/208x183/000/fff",
                    PublishOn = DateTime.UtcNow,
                    Brand = "",
                    BrandInfo = "",
                    Tags = tagList,
                    MainTag = "tshirt",
                    Price = 99,
                    Amount = 99,
                    IsSale = false,
                    IsHigLight = true
                },
                new Product()
                {
                    ID = 2, 
                    Name = "Easy Polo Black Edition",
                    ProductCategory = productCategory,
                    Description = "",
                    RawPicUrl = "",
                    PicLargeUrl = "",
                    PicMediumUrl = "http://dummyimage.com/268x249/000/fff",
                    PicSmallUrl = "",
                    PicFeaturedUrl = "http://dummyimage.com/208x183/000/fff",
                    PublishOn = DateTime.UtcNow,
                    Brand = "",
                    BrandInfo = "",
                    Tags = tagList,
                    MainTag = "blazers",
                    Price = 99,
                    Amount = 99,
                    IsSale = false,
                    IsHigLight = false
                },
                new Product()
                {
                    ID = 3, 
                    Name = "Easy Polo Black Edition",
                    ProductCategory = productCategory,
                    Description = "",
                    RawPicUrl = "",
                    PicLargeUrl = "",
                    PicMediumUrl = "http://dummyimage.com/268x249/000/fff",
                    PicSmallUrl = "",
                    PicFeaturedUrl = "http://dummyimage.com/208x183/000/fff",
                    PublishOn = DateTime.UtcNow,
                    Brand = "",
                    BrandInfo = "",
                    Tags = tagList,
                    MainTag = "sunglass",
                    Price = 99,
                    Amount = 99,
                    IsSale = true,
                    IsHigLight = false
                },
                new Product()
                {
                    ID = 4, 
                    Name = "Easy Polo Black Edition",
                    ProductCategory = productCategory,
                    Description = "",
                    RawPicUrl = "",
                    PicLargeUrl = "",
                    PicMediumUrl = "http://dummyimage.com/268x249/000/fff",
                    PicSmallUrl = "",
                    PicFeaturedUrl = "http://dummyimage.com/208x183/000/fff",
                    PublishOn = DateTime.UtcNow,
                    Brand = "",
                    BrandInfo = "",
                    Tags = tagList,
                    MainTag = "kids",
                    Price = 99,
                    Amount = 99,
                    IsSale = false,
                    IsHigLight = true
                },
                new Product()
                {
                    ID = 5, 
                    Name = "Easy Polo Black Edition",
                    ProductCategory = productCategory,
                    Description = "",
                    RawPicUrl = "",
                    PicLargeUrl = "",
                    PicMediumUrl = "http://dummyimage.com/268x249/000/fff",
                    PicSmallUrl = "",
                    PicFeaturedUrl = "http://dummyimage.com/208x183/000/fff",
                    PublishOn = DateTime.UtcNow,
                    Brand = "",
                    BrandInfo = "",
                    Tags = tagList,
                    MainTag = "poloshirt",
                    Price = 99,
                    Amount = 99,
                    IsSale = false,
                    IsHigLight = false
                },
                new Product()
                {
                    ID = 6, 
                    Name = "Easy Polo Black Edition",
                    ProductCategory = productCategory,
                    Description = "",
                    RawPicUrl = "",
                    PicLargeUrl = "",
                    PicMediumUrl = "http://dummyimage.com/268x249/000/fff",
                    PicSmallUrl = "",
                    PicFeaturedUrl = "http://dummyimage.com/208x183/000/fff",
                    PublishOn = DateTime.UtcNow,
                    Brand = "",
                    BrandInfo = "",
                    Tags = tagList,
                    MainTag = "poloshirt",
                    Price = 99,
                    Amount = 99,
                    IsSale = true,
                    IsHigLight = false
                }
            };
            #endregion
            ViewBag.ProductList = ProductList;
        }

        //取得特定商品資訊
        void GetProductDetail(int ID = 0) 
        {
            /*
            var Detail = db.Products.Find(ID);
            ViewBag.ProductDetail = Detail;
            return null;

            //if null, return to index
            if (Detail == null) 
            {
                return RedirectToAction("Index", "Home");
            }
             */

            #region fake data - product detail

            var productCategory = new ProductCategory() { ID = 1, Name = "WOMENS" };

            var tag = new Tag() { ID = 1, Name = "New Arrival" };
            var tagList = new List<Tag>();
            tagList.Add(tag);

            var Detail = new Product()
            {
                ID = 1,
                Name = "Easy Polo Black Edition",
                ProductCategory = productCategory,
                Description = "Easy Polo Black Edition",
                RawPicUrl = "/Content/eshopper/images/temp_329x380.png",
                PicLargeUrl = "/Content/eshopper/images/temp_329x380.png",
                PicMediumUrl = "/Content/eshopper/images/temp_255x381.png",
                PicFeaturedUrl = "http://dummyimage.com/208x183/000/fff",
                PicSmallUrl = "/Content/eshopper/images/temp_85x84.png",
                PublishOn = DateTime.UtcNow,
                Brand = "E-Shopper",
                BrandInfo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                Tags = tagList,
                MainTag = "poloshirt",
                Price = 999,
                Amount = 99,
                IsSale = false,
                IsHigLight = true
            };

            #endregion

            ViewBag.ProductDetail = Detail; 
        }

        //取得輪播資料
        void GetCarouselList()
        {
            #region Carousel List
            var carouselList = new List<Common.Carousel>() 
            { 
                new Common.Carousel()
                {
                    Heading = "E-SHOPPER",
                    Caption = "Free E-Commerce Template",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Link = "/EShopper/Home/Product?id=1",
                    ImageUrl = "/Content/eshopper/images/home/girl1.jpg",
                    PriceImageUrl = "/Content/eshopper/images/home/pricing.png",
                    IsHighlight = true
                },
                new Common.Carousel()
                {
                    Heading = "E-SHOPPER",
                    Caption = "100% Responsive Design",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Link = "/EShopper/Home/Product?id=2",
                    ImageUrl = "/Content/eshopper/images/home/girl2.jpg",
                    PriceImageUrl = "/Content/eshopper/images/home/pricing.png",
                    IsHighlight = false
                },
                new Common.Carousel()
                {
                    Heading = "E-SHOPPER",
                    Caption = "Free Ecommerce Template",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Link = "/EShopper/Home/Product?id=3",
                    ImageUrl = "/Content/eshopper/images/home/girl3.jpg",
                    PriceImageUrl = "/Content/eshopper/images/home/pricing.png",
                    IsHighlight = false
                }
            }; 
            #endregion

            ViewBag.CarouselList = carouselList;
        }

        //取得特色商品列表
        void GetFeaturedProductList() 
        {
            #region fake data - product
            var productCategory = new ProductCategory() { ID = 1, Name = "WOMENS" };

            var tag = new Tag() { ID = 1, Name = "New Arrival" };
            var tagList = new List<Tag>();
            tagList.Add(tag);

            var featuresProductList = new List<Product>()
            {
                new Product()
                {
                    ID = 1, 
                    Name = "Easy Polo Black Edition",
                    ProductCategory = productCategory,
                    Description = "",
                    RawPicUrl = "",
                    PicLargeUrl = "",
                    PicMediumUrl = "/Content/eshopper/images/home/product1.jpg",
                    PicSmallUrl = "",
                    PicFeaturedUrl = "http://dummyimage.com/208x183/000/fff",
                    PublishOn = DateTime.UtcNow,
                    Brand = "",
                    BrandInfo = "",
                    Tags = tagList,
                    MainTag = "poloshirt",
                    Price = 99,
                    Amount = 99,
                    IsSale = false,
                    IsHigLight = true
                },
                new Product()
                {
                    ID = 4, 
                    Name = "Easy Polo Black Edition",
                    ProductCategory = productCategory,
                    Description = "",
                    RawPicUrl = "",
                    PicLargeUrl = "",
                    PicMediumUrl = "/Content/eshopper/images/home/product1.jpg",
                    PicSmallUrl = "",
                    PicFeaturedUrl = "http://dummyimage.com/208x183/000/fff",
                    PublishOn = DateTime.UtcNow,
                    Brand = "",
                    BrandInfo = "",
                    Tags = tagList,
                    MainTag = "poloshirt",
                    Price = 99,
                    Amount = 99,
                    IsSale = false,
                    IsHigLight = true
                },
                new Product()
                {
                    ID = 7, 
                    Name = "Easy Polo Black Edition",
                    ProductCategory = productCategory,
                    Description = "",
                    RawPicUrl = "",
                    PicLargeUrl = "",
                    PicMediumUrl = "/Content/eshopper/images/home/product1.jpg",
                    PicSmallUrl = "",
                    PicFeaturedUrl = "http://dummyimage.com/208x183/000/fff",
                    PublishOn = DateTime.UtcNow,
                    Brand = "",
                    BrandInfo = "",
                    Tags = tagList,
                    MainTag = "poloshirt",
                    Price = 99,
                    Amount = 99,
                    IsSale = false,
                    IsHigLight = true
                }
            };
            #endregion

            ViewBag.FeaturesProductList = featuresProductList;
        }

        //取得主要標籤列表
        void GetMainTagList() 
        {
            #region fake data - main tag
            var mainTagList = new List<Common.MainTag>()
            {
                new Common.MainTag() { ID = 1, Name = "tshirt"},
                new Common.MainTag() { ID = 2, Name = "blazers"},
                new Common.MainTag() { ID = 3, Name = "sunglass"},
                new Common.MainTag() { ID = 4, Name = "kids"},
                new Common.MainTag() { ID = 5, Name = "poloshirt"}
            };
            #endregion

            ViewBag.MainTagList = mainTagList;            
        }

        //取得特定標籤的商品列表
        void GetTaggableProduct() 
        {
            var tagProduct = new Common.TagProduct()
            {
                ID = 1,
                Name = "Easy Polo Black Edition",
                Price = 666,
                PicUrl = "http://dummyimage.com/208x183/000/fff"
            };

            List<Common.TagProduct> tagProductList = new List<Common.TagProduct>();
            tagProductList.Add(tagProduct);
            tagProductList.Add(tagProduct);
            tagProductList.Add(tagProduct);
            tagProductList.Add(tagProduct);

            var tagListProductList = new List<Common.TagProductList>() 
            { 
                new Common.TagProductList() 
                { 
                    ID = 1, 
                    Name = "tshirt",
                    TagProduct = tagProductList
                },
                new Common.TagProductList() 
                { 
                    ID = 2, 
                    Name = "blazers",
                    TagProduct = tagProductList
                },
                new Common.TagProductList() 
                { 
                    ID = 3, 
                    Name = "sunglass",
                    TagProduct = tagProductList
                },
                new Common.TagProductList() 
                { 
                    ID = 4, 
                    Name = "kids",
                    TagProduct = tagProductList
                },
                new Common.TagProductList() 
                { 
                    ID = 5, 
                    Name = "poloshirt",
                    TagProduct = tagProductList
                }
            };
            ViewBag.TagListProductList = tagListProductList;
        }

        //取得推薦商品列表
        void GetRecommendItemsList() 
        {
            var recommendItemsList = new List<Common.RecommendItem>()
            {
                new Common.RecommendItem() 
                { 
                    ID = 1, 
                    Name = "Chiffon fabric evening dress",
                    Price = 1024,
                    PicUrl = "http://dummyimage.com/255x128/000/fff"
                },
                new Common.RecommendItem() 
                { 
                    ID = 2, 
                    Name = "barber work shirt",
                    Price = 777,
                    PicUrl = "http://dummyimage.com/255x128/666/fff"
                },
                new Common.RecommendItem() 
                { 
                    ID = 3, 
                    Name = "New Fashion 5 buttons Ladies...",
                    Price = 666,
                    PicUrl = "http://dummyimage.com/255x128/faf378/fff"
                },
                new Common.RecommendItem() 
                { 
                    ID = 4, 
                    Name = "Lady's seamless wholesale bandeau...",
                    PicUrl = "http://dummyimage.com/255x128/78fabb/fff"
                },
                new Common.RecommendItem() 
                { 
                    ID = 5, 
                    Name = "2014 high quality...",
                    Price = 399,
                    PicUrl = "http://dummyimage.com/255x128/666/fff"
                },
                new Common.RecommendItem() 
                { 
                    ID = 6, 
                    Name = "Knitwear Pullover",
                    Price = 199,
                    PicUrl = "http://dummyimage.com/255x128/000/fff"
                }
            };
            ViewBag.RecommendItemsList = recommendItemsList;
        }

        //取得所有商品
        void GetAllProducts()
        {
            var dbData = db.Products.ToList();
            
            #region fake data
            /*
            if (dbData.Count == 0)
            {
                var productList = new List<Product>()
                {
                    new Product()
                    {
                        ID = 1, 
                        Name = "Applique Crew Sweatshirt",
                        ProductCategory = new ProductCategory { ID = 1, Name = "WOMENS"},
                        Description = "Meet your new go-to sweatshirt. 60% Cotton, 40% Polyester. Soft cotton blend fleece. Ribbed crew neck. Raglan long sleeves. Shimmery signature applique. Ribbed cuffs and hem. Imported, Machine Wash.",
                        RawPicUrl = "http://goo.gl/iYWfvH",
                        PicLargeUrl = "http://goo.gl/tT3P3q",
                        PicMediumUrl = "http://goo.gl/r6BP6P",
                        PicSmallUrl = "http://goo.gl/s5LACB",
                        PicFeaturedUrl = "http://goo.gl/7A8oWr",
                        PublishOn = DateTime.UtcNow,
                        Brand = "American Eagle Outfitters",
                        BrandInfo = "Shop American Eagle Outfitters for men's and women's on-trend clothes, shoes, and more. All styles are available in additional sizes only at ae.com.",
                        //Tags = new List<Tag> { new Tag{ID = 1, Name = "sweatshirt"}},
                        MainTag = "sweatshirt",
                        Price = 1215,
                        Amount = 99,
                        IsSale = false,
                        IsHigLight = true
                    },
                    new Product()
                    {
                        ID = 2, 
                        Name = "Long Sleeve Oxford Shirt",
                        ProductCategory = new ProductCategory { ID = 1, Name = "WOMENS"},
                        Description = "The classics never go out of style.",
                        RawPicUrl = "http://goo.gl/iYWfvH",
                        PicLargeUrl = "http://goo.gl/tT3P3q",
                        PicMediumUrl = "http://goo.gl/r6BP6P",
                        PicSmallUrl = "http://goo.gl/s5LACB",
                        PicFeaturedUrl = "http://goo.gl/7A8oWr",
                        PublishOn = DateTime.UtcNow,
                        Brand = "American Eagle Outfitters",
                        BrandInfo = "Shop American Eagle Outfitters for men's and women's on-trend clothes, shoes, and more. All styles are available in additional sizes only at ae.com.",
                        //Tags = new List<Tag> { new Tag{ID = 2, Name = "shirt"}, new Tag { ID = 3, Name = "AE" }},
                        MainTag = "shirt",
                        Price = 1215,
                        Amount = 50,
                        IsSale = true,
                        IsHigLight = true
                    },
                    new Product()
                    {
                        ID = 3, 
                        Name = "Signature Long Sleeve T-Shirt",
                        ProductCategory = new ProductCategory { ID = 2, Name = "MENS"},
                        Description = "Show off your signature #AEOSTYLE.",
                        RawPicUrl = "http://goo.gl/iYWfvH",
                        PicLargeUrl = "http://goo.gl/tT3P3q",
                        PicMediumUrl = "http://goo.gl/r6BP6P",
                        PicSmallUrl = "http://goo.gl/s5LACB",
                        PicFeaturedUrl = "http://goo.gl/7A8oWr",
                        PublishOn = DateTime.UtcNow,
                        Brand = "American Eagle Outfitters",
                        BrandInfo = "Shop American Eagle Outfitters for men's and women's on-trend clothes, shoes, and more. All styles are available in additional sizes only at ae.com.",
                        //Tags = new List<Tag> { new Tag { ID = 3, Name = "AE" }, new Tag{ID = 4, Name = "t-shirt"}},
                        MainTag = "t-shirt",
                        Price = 606,
                        Amount = 60,
                        IsSale = false,
                        IsHigLight = false
                    },
                    new Product()
                    {
                        ID = 4, 
                        Name = "High Top Sneakers",
                        ProductCategory = new ProductCategory { ID = 3, Name = "KIDS"},
                        Description = "High tops with elasticized laces, a tab, and velcro fastener. Rubber soles. (Soft sole in sizes 0.5 and 1)",
                        RawPicUrl = "http://goo.gl/iYWfvH",
                        PicLargeUrl = "http://goo.gl/tT3P3q",
                        PicMediumUrl = "http://goo.gl/r6BP6P",
                        PicSmallUrl = "http://goo.gl/s5LACB",
                        PicFeaturedUrl = "http://goo.gl/7A8oWr",
                        PublishOn = DateTime.UtcNow,
                        Brand = "H&M",
                        BrandInfo = "Offers clothing for men, women and children. United Kingdom.",
                        //Tags = new List<Tag> { new Tag{ID = 5, Name = "sneaker"}, new Tag { ID = 6, Name = "H&M" }},
                        MainTag = "sneaker",
                        Price = 390,
                        Amount = 20,
                        IsSale = false,
                        IsHigLight = true
                    },
                    new Product()
                    {
                        ID = 5, 
                        Name = "Fleece Jacket",
                        ProductCategory = new ProductCategory { ID = 4, Name = "SPORTSWEAR"},
                        Description = "Jacket in fast-drying fleece. Zip at front, side pockets with zip, and hood with elasticized drawstring. Ribbed cuffs with thumbholes. Unlined.",
                        RawPicUrl = "http://goo.gl/iYWfvH",
                        PicLargeUrl = "http://goo.gl/tT3P3q",
                        PicMediumUrl = "http://goo.gl/r6BP6P",
                        PicSmallUrl = "http://goo.gl/s5LACB",
                        PicFeaturedUrl = "http://goo.gl/7A8oWr",
                        PublishOn = DateTime.UtcNow,
                        Brand = "H&M",
                        BrandInfo = "Offers clothing for men, women and children. United Kingdom.",
                        //Tags = new List<Tag> { new Tag { ID = 6, Name = "H&M" }, new Tag { ID = 7, Name = "fast-drying" }},
                        MainTag = "fast-drying",
                        Price = 900,
                        Amount = 999,
                        IsSale = false,
                        IsHigLight = false
                    },
                    new Product()
                    {
                        ID = 6, 
                        Name = "Therapy Faux Fur Booties",
                        ProductCategory = new ProductCategory { ID = 5, Name = "HOUSEHOLDS"},
                        Description = "Therapy Faux Fur booties.",
                        RawPicUrl = "http://goo.gl/iYWfvH",
                        PicLargeUrl = "http://goo.gl/tT3P3q",
                        PicMediumUrl = "http://goo.gl/r6BP6P",
                        PicSmallUrl = "http://goo.gl/s5LACB",
                        PicFeaturedUrl = "http://goo.gl/7A8oWr",
                        PublishOn = DateTime.UtcNow,
                        Brand = "House of Fraser",
                        BrandInfo = "House of Fraser Catalogue - UK's Department Store of choice. Shop from a massive selection of your favourite Home, Clothing & Beauty brands this Spring 2014!",
                        //Tags = new List<Tag> { new Tag{ID = 8, Name = "bootie"}, new Tag { ID = 9, Name = "House of Fraser" }}, 
                        MainTag = "bootie",
                        Price = 300,
                        Amount = 99,
                        IsSale = true,
                        IsHigLight = false
                    },
                    new Product()
                    {
                        ID = 7, 
                        Name = "Handbag",
                        ProductCategory = new ProductCategory { ID = 6, Name = "BAGS & SHOES"},
                        Description = "Handbag in thick, embossed imitation leather with double handles and top zip. Detachable shoulder strap, one inner compartment with zip, and studs on base. Size 10 1/2 x 13 3/4 in.",
                        RawPicUrl = "http://goo.gl/iYWfvH",
                        PicLargeUrl = "http://goo.gl/tT3P3q",
                        PicMediumUrl = "http://goo.gl/r6BP6P",
                        PicSmallUrl = "http://goo.gl/s5LACB",
                        PicFeaturedUrl = "http://goo.gl/7A8oWr",
                        PublishOn = DateTime.UtcNow,
                        Brand = "H&M",
                        BrandInfo = "Offers clothing for men, women and children. United Kingdom.",
                        //Tags = new List<Tag> { new Tag{ID = 6, Name = "H&M"}, new Tag { ID = 10, Name = "handbag" }},
                        MainTag = "handbag",
                        Price = 1200,
                        Amount = 50,
                        IsSale = false,
                        IsHigLight = true
                    }
                };

                db.SaveChanges();
                dbData = db.Products.ToList();
            }
            */
            #endregion

            ViewBag.ProductList = dbData;
        }

        #endregion
    }
}
