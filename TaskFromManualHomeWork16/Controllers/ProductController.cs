using Microsoft.AspNetCore.Mvc;
using TaskFromManualHomeWork16.Model;

namespace TaskFromManualHomeWork16.Controllers
{
    //Сделал всё, единственное что, под последние два задания (сумма продуктов и сумма продуктов по категориям) я не делал новый контроллер, всё сделал в 1
    [Route("product")]
    public class ProductController : ControllerBase
    {
        List<ProductModel> products = new List<ProductModel>() { 
            new ProductModel() { ProductId = 1, ProductName = "Chair", ProductAmount = 12, Category="Furniture" },
            new ProductModel() { ProductId = 2, ProductName = "Table", ProductAmount = 15, Category="Furniture" },
            new ProductModel() { ProductId = 3, ProductName = "Door", ProductAmount = 28, Category="Furniture" },
            new ProductModel() { ProductId = 4, ProductName = "Bush", ProductAmount = 13, Category="Nature" },
            new ProductModel() { ProductId = 5, ProductName = "Tree", ProductAmount = 55, Category="Nature" },
            new ProductModel() { ProductId = 6, ProductName = "Flower", ProductAmount = 75, Category="Nature" },
            new ProductModel() { ProductId = 7, ProductName = "Gloves", ProductAmount = 23, Category="Clothe" },
            new ProductModel() { ProductId = 8, ProductName = "Jacket", ProductAmount = 87, Category="Clothe" }
        };

        [HttpGet]
        [Route("getProducts")]
        public ProductModel[] ProductGet()
        {
            if (products != null)
            {
                return products.ToArray();
            }
            return null;
        }

        [HttpGet]
        [Route("getProducts/{id}")]
        public IEnumerable<ProductModel> ProductIdGet(int? id)
        {
            if (products != null && id!=null)
            {
                return products.Where(p => p.ProductId == id);
            }
            return null;
        }

        [HttpPost]
        [Route("addProducts/{id:int}/{name}/{amount:int}")]
        public ProductModel[] ProductAdd(int id, string name, int amount)
        {
            for(int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductId == id)
                {
                    products[i].ProductId = id;
                    products[i].ProductName = name;
                    products[i].ProductAmount = amount;
                    return products.ToArray();
                }
            }
            products.Add(new ProductModel() { ProductId = id, ProductName = name, ProductAmount = amount });
            return products.ToArray();
        }

        [HttpGet]
        [Route("getProductsAmount")]
        public int ProductsAmountGet()
        {
            if(products != null)
            {
                int amount = 0;
                foreach(var product in products)
                {
                    amount += product.ProductAmount;
                }
                return amount;
            }
            return -1;
        }

        [HttpGet]
        [Route("getProductsByCategory/{category}")]
        public int ProductsCategoryAmountGet(string category)
        {
            if (products != null)
            {
                int amount = 0;
                foreach (var product in products)
                {
                    if(product.Category == category)
                    {
                        amount += product.ProductAmount;
                    }
                    else
                    {
                        continue;
                    }
                }
                return amount;
            }
            return -1;
        }

    }
}
