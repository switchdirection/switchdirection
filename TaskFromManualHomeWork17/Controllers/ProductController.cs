using Microsoft.AspNetCore.Mvc;
using TaskFromManualHomeWork17.Models;

namespace TaskFromManualHomeWork17.Controllers
{
    public class ProductController : Controller
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

        public IActionResult Product()
        {
            if (products != null)
            {
                return View(products);
            }
            return NoContent();
        }

        [HttpPost]
        [Route("getProducts")]
        public IActionResult ProductGet()
        {
            if (products != null)
            {
                
                return View(products);
            }
            return NoContent();
        }



        [HttpPost]
        [HttpPost]
        public IActionResult ProductIdGet(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                ViewBag.Message = "Product not found.";
            }
            else
            {
                ViewBag.Product = product;
            }

            return View("Product", products);
        }

        [HttpPost]
        public IActionResult ProductAdd(int id, string name, int amount)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductId == id)
                {
                    products[i].ProductId = id;
                    products[i].ProductName = name;
                    products[i].ProductAmount = amount;
                    return RedirectToAction("Product");
                }
            }
            products.Add(new ProductModel() { ProductId = id, ProductName = name, ProductAmount = amount });
            return RedirectToAction("Product");
        }

        [HttpPost]
        public IActionResult ProductsAmountGet()
        {
            if (products != null)
            {
                int amount = 0;
                foreach (var product in products)
                {
                    amount += product.ProductAmount;
                }
                ViewBag.Amount = amount;
            }
            else
            {
                ViewBag.Amount = 0;
            }
            return View("Product", products);
            
        }

        [HttpPost]
        public IActionResult ProductsCategoryAmountGet(string category)
        {
            if (products != null)
            {
                int amount = 0;
                foreach (var product in products)
                {
                    if (product.Category == category)
                    {
                        amount += product.ProductAmount;
                    }
                    else
                    {
                        continue;
                    }
                }
                ViewBag.CategoryAmount = amount;
            }
            else
            {
                ViewBag.Message = "Category not found";
            }
            return View("Product", products);
        }
    }
}
