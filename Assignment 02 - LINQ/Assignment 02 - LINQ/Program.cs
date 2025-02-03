#region LINQ - Element Operators
#region 1. Get first Product out of Stock 

//{
//    List<Product> products = new List<Product>
//        {
//            new Product { Id = 1, Name = "Laptop", Stock = 10 },
//            new Product { Id = 2, Name = "Phone", Stock = 0 },
//            new Product { Id = 3, Name = "Tablet", Stock = 5 },
//            new Product { Id = 4, Name = "Headphones", Stock = 0 }
//        };

//    Product firstOutOfStockProduct = products.FirstOrDefault(p => p.Stock == 0);

//    if (firstOutOfStockProduct != null)
//    {
//        Console.WriteLine($"First out-of-stock product: {firstOutOfStockProduct.Name}");
//    }
//    else
//    {
//        Console.WriteLine("No out-of-stock products found.");
//    }
//}
//}

//class Product
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Stock { get; set; }
//}

#endregion
#region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

//{
//    List<Product> products = new List<Product>
//        {
//            new Product { Id = 1, Name = "Laptop", Price = 1200 },
//            new Product { Id = 2, Name = "Phone", Price = 800 },
//            new Product { Id = 3, Name = "Tablet", Price = 1500 },
//            new Product { Id = 4, Name = "Headphones", Price = 200 }
//        };

//    Product firstExpensiveProduct = products.FirstOrDefault(p => p.Price > 1000);

//    if (firstExpensiveProduct != null)
//    {
//        Console.WriteLine($"First product with price > 1000: {firstExpensiveProduct.Name}");
//    }
//    else
//    {
//        Console.WriteLine("No product found with price > 1000.");
//    }
//}
//}

//class Product
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Price { get; set; }
//}

#endregion
#region 3. Retrieve the second number greater than 5 

//{
//    int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//    int? secondNumber = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();

//    if (secondNumber != 0)
//    {
//        Console.WriteLine($"Second number greater than 5: {secondNumber}");
//    }
//    else
//    {
//        Console.WriteLine("No second number greater than 5 found.");
//    }
//}

#endregion
#endregion
#region LINQ - Aggregate Operators
#region 1. Uses Count to get the number of odd numbers in the array

//{
//    int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//    int oddCount = Arr.Count(n => n % 2 != 0);

//    Console.WriteLine($"Number of odd numbers: {oddCount}");
//}

#endregion
#region 2. Return a list of customers and how many orders each has.

//{
//    List<Customer> customers = new List<Customer>
//        {
//            new Customer { Id = 1, Name = "Alice", Orders = new List<Order> { new Order(), new Order() } },
//            new Customer { Id = 2, Name = "Bob", Orders = new List<Order> { new Order() } },
//            new Customer { Id = 3, Name = "Charlie", Orders = new List<Order> { new Order(), new Order(), new Order() } },
//            new Customer { Id = 4, Name = "David", Orders = new List<Order>() }
//        };

//    var customerOrderCounts = customers.Select(c => new
//    {
//        CustomerName = c.Name,
//        OrderCount = c.Orders.Count
//    });

//    foreach (var item in customerOrderCounts)
//    {
//        Console.WriteLine($"{item.CustomerName} has {item.OrderCount} orders.");
//    }
//}
//}

//class Customer
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public List<Order> Orders { get; set; } = new List<Order>();
//}

//class Order
//{
//    public int OrderId { get; set; }
//}

#endregion
#region 3. Return a list of categories and how many products each has

//{
//    List<Category> categories = new List<Category>
//        {
//            new Category { Id = 1, Name = "Electronics", Products = new List<Product>
//                { new Product(), new Product(), new Product() } },
//            new Category { Id = 2, Name = "Clothing", Products = new List<Product>
//                { new Product(), new Product() } },
//            new Category { Id = 3, Name = "Books", Products = new List<Product>
//                { new Product() } },
//            new Category { Id = 4, Name = "Furniture", Products = new List<Product>() }
//        };

//    var categoryProductCounts = categories.Select(c => new
//    {
//        CategoryName = c.Name,
//        ProductCount = c.Products.Count
//    });

//    foreach (var item in categoryProductCounts)
//    {
//        Console.WriteLine($"{item.CategoryName} has {item.ProductCount} products.");
//    }
//}
//}

//class Category
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public List<Product> Products { get; set; } = new List<Product>();
//}

//class Product
//{
//    public int ProductId { get; set; }
//}

#endregion
#region 4. Get the total of the numbers in an array.

//{
//    int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//    int totalSum = Arr.Sum();

//    Console.WriteLine($"Total sum of numbers: {totalSum}");
//}

#endregion
#region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

//if (!File.Exists("dictionary_english.txt"))
//{
//    Console.WriteLine("Error: File not found!");
//    return;
//}

#endregion
#region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

//{
//    string[] words = File.ReadAllLines("dictionary_english.txt");
//    int shortestWordLength = words.Min(word => word.Length);
//    Console.WriteLine($"Length of the shortest word: {shortestWordLength}");
//}

#endregion
#region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

//{
//    string[] words = File.ReadAllLines("dictionary_english.txt");
//    int longestWordLength = words.Max(word => word.Length);
//    Console.WriteLine($"Length of the longest word: {longestWordLength}");
//}

#endregion
#region 8.Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

//{
//    string[] words = File.ReadAllLines("dictionary_english.txt");
//    double averageWordLength = words.Average(word => word.Length);
//    Console.WriteLine($"Average length of the words: {averageWordLength}");
//}

#endregion
#region 9. Get the total units in stock for each product category.

//{
//    List<Category> categories = new List<Category>
//        {
//            new Category { Id = 1, Name = "Electronics", Products = new List<Product>
//                { new Product { Name = "Laptop", UnitsInStock = 5 },
//                  new Product { Name = "Smartphone", UnitsInStock = 10 } } },
//            new Category { Id = 2, Name = "Clothing", Products = new List<Product>
//                { new Product { Name = "T-shirt", UnitsInStock = 20 },
//                  new Product { Name = "Jeans", UnitsInStock = 15 } } },
//            new Category { Id = 3, Name = "Books", Products = new List<Product>
//                { new Product { Name = "Novel", UnitsInStock = 30 } } }
//        };

//    var categoryStock = categories.Select(c => new
//    {
//        CategoryName = c.Name,
//        TotalUnitsInStock = c.Products.Sum(p => p.UnitsInStock)
//    });

//    foreach (var item in categoryStock)
//    {
//        Console.WriteLine($"{item.CategoryName} has {item.TotalUnitsInStock} units in stock.");
//    }
//}
//}

//class Category
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public List<Product> Products { get; set; } = new List<Product>();
//}

//class Product
//{
//    public string Name { get; set; }
//    public int UnitsInStock { get; set; }
//}

#endregion
#region 10. Get the cheapest price among each category's products

//{
//    List<Category> categories = new List<Category>
//        {
//            new Category { Id = 1, Name = "Electronics", Products = new List<Product>
//                { new Product { Name = "Laptop", Price = 800 },
//                  new Product { Name = "Smartphone", Price = 500 } } },
//            new Category { Id = 2, Name = "Clothing", Products = new List<Product>
//                { new Product { Name = "T-shirt", Price = 20 },
//                  new Product { Name = "Jeans", Price = 50 } } },
//            new Category { Id = 3, Name = "Books", Products = new List<Product>
//                { new Product { Name = "Novel", Price = 15 } } }
//        };

//    var cheapestPrices = categories.Select(c => new
//    {
//        CategoryName = c.Name,
//        CheapestPrice = c.Products.Min(p => p.Price)
//    });

//    foreach (var item in cheapestPrices)
//    {
//        Console.WriteLine($"The cheapest price in {item.CategoryName} is {item.CheapestPrice}");
//    }
//}
//}

//class Category
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public List<Product> Products { get; set; } = new List<Product>();
//}

//class Product
//{
//    public string Name { get; set; }
//    public double Price { get; set; }
//}

#endregion
#region 11. Get the products with the cheapest price in each category (Use Let)

//{
//    List<Category> categories = new List<Category>
//        {
//            new Category { Id = 1, Name = "Electronics", Products = new List<Product>
//                { new Product { Name = "Laptop", Price = 800 },
//                  new Product { Name = "Smartphone", Price = 500 } } },
//            new Category { Id = 2, Name = "Clothing", Products = new List<Product>
//                { new Product { Name = "T-shirt", Price = 20 },
//                  new Product { Name = "Jeans", Price = 50 } } },
//            new Category { Id = 3, Name = "Books", Products = new List<Product>
//                { new Product { Name = "Novel", Price = 15 },
//                  new Product { Name = "Magazine", Price = 10 } } }
//        };

//    var productsWithCheapestPrice = categories.Select(c => new
//    {
//        CategoryName = c.Name,
//        CheapestPriceProduct = c.Products
//            .Let(products => products.Where(p => p.Price == products.Min(product => product.Price)))
//    });

//    foreach (var item in productsWithCheapestPrice)
//    {
//        Console.WriteLine($"In {item.CategoryName}:");
//        foreach (var product in item.CheapestPriceProduct)
//        {
//            Console.WriteLine($"- {product.Name} with price {product.Price}");
//        }
//    }
//}
//}

//class Category
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public List<Product> Products { get; set; } = new List<Product>();
//}

//class Product
//{
//    public string Name { get; set; }
//    public double Price { get; set; }
//}

#endregion
#region 12. Get the most expensive price among each category's products.

//{
//    List<Category> categories = new List<Category>
//        {
//            new Category { Id = 1, Name = "Electronics", Products = new List<Product>
//                { new Product { Name = "Laptop", Price = 800 },
//                  new Product { Name = "Smartphone", Price = 500 } } },
//            new Category { Id = 2, Name = "Clothing", Products = new List<Product>
//                { new Product { Name = "T-shirt", Price = 20 },
//                  new Product { Name = "Jeans", Price = 50 } } },
//            new Category { Id = 3, Name = "Books", Products = new List<Product>
//                { new Product { Name = "Novel", Price = 15 },
//                  new Product { Name = "Magazine", Price = 10 } } }
//        };

//    var mostExpensivePrices = categories.Select(c => new
//    {
//        CategoryName = c.Name,
//        MostExpensivePrice = c.Products.Max(p => p.Price)
//    });

//    foreach (var item in mostExpensivePrices)
//    {
//        Console.WriteLine($"The most expensive price in {item.CategoryName} is {item.MostExpensivePrice}");
//    }
//}
//}

//class Category
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public List<Product> Products { get; set; } = new List<Product>();
//}

//class Product
//{
//    public string Name { get; set; }
//    public double Price { get; set; }
//}

#endregion
#region 13. Get the products with the most expensive price in each category.

//{
//    List<Category> categories = new List<Category>
//        {
//            new Category { Id = 1, Name = "Electronics", Products = new List<Product>
//                { new Product { Name = "Laptop", Price = 800 },
//                  new Product { Name = "Smartphone", Price = 500 } } },
//            new Category { Id = 2, Name = "Clothing", Products = new List<Product>
//                { new Product { Name = "T-shirt", Price = 20 },
//                  new Product { Name = "Jeans", Price = 50 } } },
//            new Category { Id = 3, Name = "Books", Products = new List<Product>
//                { new Product { Name = "Novel", Price = 15 },
//                  new Product { Name = "Magazine", Price = 10 } } }
//        };

//    var productsWithMostExpensivePrice = categories.Select(c => new
//    {
//        CategoryName = c.Name,
//        MostExpensiveProducts = c.Products
//            .Where(p => p.Price == c.Products.Max(product => product.Price))
//    });

//    foreach (var item in productsWithMostExpensivePrice)
//    {
//        Console.WriteLine($"In {item.CategoryName}:");
//        foreach (var product in item.MostExpensiveProducts)
//        {
//            Console.WriteLine($"- {product.Name} with price {product.Price}");
//        }
//    }
//}
//}

//class Category
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public List<Product> Products { get; set; } = new List<Product>();
//}

//class Product
//{
//    public string Name { get; set; }
//    public double Price { get; set; }
//}

#endregion
#region 14. Get the average price of each category's products.

//{
//    List<Category> categories = new List<Category>
//        {
//            new Category { Id = 1, Name = "Electronics", Products = new List<Product>
//                { new Product { Name = "Laptop", Price = 800 },
//                  new Product { Name = "Smartphone", Price = 500 } } },
//            new Category { Id = 2, Name = "Clothing", Products = new List<Product>
//                { new Product { Name = "T-shirt", Price = 20 },
//                  new Product { Name = "Jeans", Price = 50 } } },
//            new Category { Id = 3, Name = "Books", Products = new List<Product>
//                { new Product { Name = "Novel", Price = 15 },
//                  new Product { Name = "Magazine", Price = 10 } } }
//        };

//    var averagePrices = categories.Select(c => new
//    {
//        CategoryName = c.Name,
//        AveragePrice = c.Products.Average(p => p.Price)
//    });

//    foreach (var item in averagePrices)
//    {
//        Console.WriteLine($"The average price in {item.CategoryName} is {item.AveragePrice:F2}");
//    }
//}
//}

//class Category
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public List<Product> Products { get; set; } = new List<Product>();
//}

//class Product
//{
//    public string Name { get; set; }
//    public double Price { get; set; }
//}

#endregion
#endregion
#region LINQ - Set Operators
#region 1. Find the unique Category names from Product List
//var uniqueCategories = productList.Select(p => p.Category).Distinct().ToList();

#endregion
#region 2. Produce a Sequence containing the unique first letter from both product and customer names.

//var uniqueFirstLetters = productList.Select(p => p.Name[0])
//    .Concat(customerList.Select(c => c.Name[0]))
//    .Distinct()
//    .OrderBy(c => c)
//    .ToList();


#endregion
#region 3. Create one sequence that contains the common first letter from both product and customer names.

//{
//    List<string> products = new List<string> { "Apple", "Banana", "Apricot", "Blueberry", "Cherry" };
//    List<string> customers = new List<string> { "Alice", "Bob", "Andrew", "Charlie", "David" };

//    var commonFirstLetters = products.Select(p => p[0])
//                                     .Intersect(customers.Select(c => c[0]))
//                                     .OrderBy(c => c);

//    Console.WriteLine("Common First Letters:");
//    foreach (var letter in commonFirstLetters)
//    {
//        Console.WriteLine(letter);
//    }
//}

#endregion
#region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

//{
//    List<string> products = new List<string> { "Apple", "Banana", "Apricot", "Blueberry", "Cherry", "Mango" };
//    List<string> customers = new List<string> { "Alice", "Bob", "Andrew", "Charlie", "David" };

//    var uniqueFirstLetters = products.Select(p => p[0])
//                                     .Except(customers.Select(c => c[0]))
//                                     .OrderBy(c => c);

//    Console.WriteLine("Unique First Letters in Product Names:");
//    foreach (var letter in uniqueFirstLetters)
//    {
//        Console.WriteLine(letter);
//    }
//}

#endregion
#region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates


//List<string> products = new List<string> { "Apple", "Banana", "Apricot", "Blueberry", "Cherry" };
//List<string> customers = new List<string> { "Alice", "Bob", "Andrew", "Charlie", "David" };

//var lastThreeChars = products.Concat(customers)
//                             .Select(name => name.Length >= 3 ? name[^3..] : name)
//                             .ToList();

//Console.WriteLine("Last Three Characters from Each Name:");
//foreach (var chars in lastThreeChars)
//{
//    Console.WriteLine(chars);
//}
//    }

#endregion



#endregion
#region LINQ - Partitioning Operators
#region 1. Get the first 3 orders from customers in Washington
//{
//    class Customer
//{
//    public string Name { get; set; }
//    public string State { get; set; }
//    public List<Order> Orders { get; set; }
//}

//class Order
//{
//    public int OrderId { get; set; }
//    public string Product { get; set; }
//}

//static void Main()
//{
//    List<Customer> customers = new List<Customer>
//        {
//            new Customer { Name = "Alice", State = "Washington", Orders = new List<Order>
//                { new Order { OrderId = 1, Product = "Laptop" }, new Order { OrderId = 2, Product = "Phone" } }
//            },
//            new Customer { Name = "Bob", State = "Washington", Orders = new List<Order>
//                { new Order { OrderId = 3, Product = "Tablet" }, new Order { OrderId = 4, Product = "Headphones" } }
//            },
//            new Customer { Name = "Charlie", State = "California", Orders = new List<Order>
//                { new Order { OrderId = 5, Product = "Monitor" } }
//            },
//            new Customer { Name = "David", State = "Washington", Orders = new List<Order>
//                { new Order { OrderId = 6, Product = "Keyboard" }, new Order { OrderId = 7, Product = "Mouse" } }
//            }
//        };

//    var firstThreeOrders = customers.Where(c => c.State == "Washington")
//                                    .SelectMany(c => c.Orders)
//                                    .Take(3)
//                                    .ToList();

//    Console.WriteLine("First 3 Orders from Washington Customers:");
//    foreach (var order in firstThreeOrders)
//    {
//        Console.WriteLine($"Order ID: {order.OrderId}, Product: {order.Product}");
//    }
//}
//}

#endregion
#region 2. Get all but the first 2 orders from customers in Washington.

//{
//        public string Name { get; set; }
//public string State { get; set; }
//public List<Order> Orders { get; set; }
//    }

//    class Order
//{
//    public int OrderId { get; set; }
//    public string Product { get; set; }
//}

//static void Main()
//{
//    List<Customer> customers = new List<Customer>
//        {
//            new Customer { Name = "Alice", State = "Washington", Orders = new List<Order>
//                { new Order { OrderId = 1, Product = "Laptop" }, new Order { OrderId = 2, Product = "Phone" } }
//            },
//            new Customer { Name = "Bob", State = "Washington", Orders = new List<Order>
//                { new Order { OrderId = 3, Product = "Tablet" }, new Order { OrderId = 4, Product = "Headphones" } }
//            },
//            new Customer { Name = "Charlie", State = "California", Orders = new List<Order>
//                { new Order { OrderId = 5, Product = "Monitor" } }
//            },
//            new Customer { Name = "David", State = "Washington", Orders = new List<Order>
//                { new Order { OrderId = 6, Product = "Keyboard" }, new Order { OrderId = 7, Product = "Mouse" } }
//            }
//        };

//    var ordersExceptFirstTwo = customers.Where(c => c.State == "Washington")
//                                        .SelectMany(c => c.Orders)
//                                        .Skip(2)
//                                        .ToList();

//    Console.WriteLine("Orders from Washington Customers (excluding first 2):");
//    foreach (var order in ordersExceptFirstTwo)
//    {
//        Console.WriteLine($"Order ID: {order.OrderId}, Product: {order.Product}");
//    }
//}
//}

#endregion
#region 3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

//{
//    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//    var result = numbers.TakeWhile((num, index) => num >= index).ToArray();

//    Console.WriteLine("Elements until a number less than its position is hit:");
//    foreach (var number in result)
//    {
//        Console.WriteLine(number);
//    }
//}

#endregion
#region 4.Get the elements of the array starting from the first element divisible by 3.

//{
//    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//    var result = numbers.SkipWhile(num => num % 3 != 0).ToArray();

//    Console.WriteLine("Elements starting from the first element divisible by 3:");
//    foreach (var number in result)
//    {
//        Console.WriteLine(number);
//    }
//}

#endregion
#region 5. Get the elements of the array starting from the first element less than its position.

//{
//    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//    var result = numbers.SkipWhile((num, index) => num >= index).ToArray();

//    Console.WriteLine("Elements starting from the first element less than its position:");
//    foreach (var number in result)
//    {
//        Console.WriteLine(number);
//    }
//}

#endregion
#endregion
#region LINQ - Quantifiers
#region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
//{
//    string[] words = File.ReadAllLines("dictionary_english.txt");

//    bool containsEi = words.Any(word => word.Contains("ei"));

//    if (containsEi)
//    {
//        Console.WriteLine("There is at least one word that contains 'ei'.");
//    }
//    else
//    {
//        Console.WriteLine("No word contains 'ei'.");
//    }
//}

#endregion
#region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

//{
//    public class Product
//{
//    public string ProductName { get; set; }
//    public string Category { get; set; }
//    public bool IsOutOfStock { get; set; }
//}

//static void Main()
//{
//    List<Product> products = new List<Product>
//        {
//            new Product { ProductName = "Laptop", Category = "Electronics", IsOutOfStock = false },
//            new Product { ProductName = "Phone", Category = "Electronics", IsOutOfStock = true },
//            new Product { ProductName = "Headphones", Category = "Electronics", IsOutOfStock = false },
//            new Product { ProductName = "Shirt", Category = "Clothing", IsOutOfStock = true },
//            new Product { ProductName = "Jeans", Category = "Clothing", IsOutOfStock = false },
//            new Product { ProductName = "Shoes", Category = "Clothing", IsOutOfStock = false },
//            new Product { ProductName = "Coffee Maker", Category = "Appliances", IsOutOfStock = false },
//        };

//    var result = products
//        .GroupBy(p => p.Category)
//        .Where(g => g.Any(p => p.IsOutOfStock))
//        .Select(g => new
//        {
//            Category = g.Key,
//            Products = g.ToList()
//        })
//        .ToList();

//    foreach (var group in result)
//    {
//        Console.WriteLine($"Category: {group.Category}");
//        foreach (var product in group.Products)
//        {
//            Console.WriteLine($" - {product.ProductName} (Out of Stock: {product.IsOutOfStock})");
//        }
//        Console.WriteLine();
//    }
//}
//}

#endregion
#region 3. Return a grouped a list of products only for categories that have all of their products in stock.

//{
//    public class Product
//{
//    public string ProductName { get; set; }
//    public string Category { get; set; }
//    public bool IsOutOfStock { get; set; }
//}

//static void Main()
//{
//    List<Product> products = new List<Product>
//        {
//            new Product { ProductName = "Laptop", Category = "Electronics", IsOutOfStock = false },
//            new Product { ProductName = "Phone", Category = "Electronics", IsOutOfStock = false },
//            new Product { ProductName = "Headphones", Category = "Electronics", IsOutOfStock = false },
//            new Product { ProductName = "Shirt", Category = "Clothing", IsOutOfStock = false },
//            new Product { ProductName = "Jeans", Category = "Clothing", IsOutOfStock = false },
//            new Product { ProductName = "Shoes", Category = "Clothing", IsOutOfStock = false },
//            new Product { ProductName = "Coffee Maker", Category = "Appliances", IsOutOfStock = false },
//        };

//    var result = products
//        .GroupBy(p => p.Category)
//        .Where(g => g.All(p => !p.IsOutOfStock))
//        .Select(g => new
//        {
//            Category = g.Key,
//            Products = g.ToList()
//        })
//        .ToList();

//    foreach (var group in result)
//    {
//        Console.WriteLine($"Category: {group.Category}");
//        foreach (var product in group.Products)
//        {
//            Console.WriteLine($" - {product.ProductName} (Out of Stock: {product.IsOutOfStock})");
//        }
//        Console.WriteLine();
//    }
//}
//}

#endregion
#endregion
#region LINQ – Grouping Operators
#region Use group by to partition a list of numbers by their remainder when divided by 5

//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

//        var groupedNumbers = numbers
//            .GroupBy(n => n % 5)
//            .OrderBy(g => g.Key); // Optional, to sort the groups by remainder

//        foreach (var group in groupedNumbers)
//        {
//            Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
//            foreach (var number in group)
//            {
//                Console.WriteLine(number);
//            }
//            Console.WriteLine();
//        }
//    }
//}

#endregion
#region Uses group by to partition a list of words by their first letter.

//{
//    static void Main()
//    {
//        List<string> words = File.ReadAllLines("dictionary_english.txt").ToList();

//        var groupedWords = words
//            .GroupBy(word => word[0]) 
//            .OrderBy(g => g.Key);      


//        foreach (var group in groupedWords)
//        {
//            Console.WriteLine($"Words starting with '{group.Key}':");
//            foreach (var word in group)
//            {
//                Console.WriteLine(word);
//            }
//            Console.WriteLine();
//        }
//    }
//}

#endregion
#region Consider this Array as an Input Use Group By with a custom comparer that matches words that are consists of the same Characters Together

//{
//    static void Main()
//    {
//        string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

//        var groupedWords = Arr
//            .GroupBy(word => string.Concat(word.OrderBy(c => c))) 
//            .OrderBy(g => g.Key);  

//        foreach (var group in groupedWords)
//        {
//            Console.WriteLine(string.Join(Environment.NewLine, group));
//            Console.WriteLine();
//        }
//    }
//}

#endregion
#endregion
