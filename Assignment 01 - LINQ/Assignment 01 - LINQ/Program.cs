using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    #region LINQ - Restriction Operators

    #region 1. Find all products that are out of stock.
    //static void Main()
    //{
    //    List<Product> products = ListGenerators.GetProducts();
    //    var outOfStockProducts = products.Where(p => p.UnitsInStock == 0);

    //    Console.WriteLine("Products that are out of stock:");
    //    foreach (var product in outOfStockProducts)
    //    {
    //        Console.WriteLine($"- {product.ProductName}");
    //    }
    //} 
    #endregion

    #region 2. Find all products that are in stock and cost more than 3.00 per unit.

    // {
    //    List<Product> products = ListGenerators.GetProducts();
    //var outOfStockProducts = products.Where(p => p.UnitsInStock == 0);

    //Console.WriteLine("Products that are out of stock:");
    //    foreach (var product in outOfStockProducts)
    //    {
    //        Console.WriteLine($"- {product.ProductName}");
    //    }

    #endregion

    #region 3. Returns digits whose name is shorter than their value.

    // {
    //    string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

    //var shortNamedDigits = Arr.Where((name, index) => name.Length < index);

    //Console.WriteLine("Digits whose name is shorter than their value:");
    //    foreach (var digit in shortNamedDigits)
    //    {
    //        Console.WriteLine(digit);
    //    }
    //}
    #endregion
}
#endregion


#region LINQ - Ordering Operators

#region 1. Sort a list of products by name


//{
//    List<Product> products = ListGenerators.GetProducts();
//    var sortedProducts = products.OrderBy(p => p.ProductName);

//    Console.WriteLine("Products sorted by name:");
//    foreach (var product in sortedProducts)
//    {
//        Console.WriteLine(product.ProductName);
//    }


#endregion

#region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

//{
//    string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

//    var sortedWords = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

//    Console.WriteLine("Words sorted case-insensitively:");
//    foreach (var word in sortedWords)
//    {
//        Console.WriteLine(word);
//    }
//}

#endregion

#region 3. Sort a list of products by units in stock from highest to lowest.

//{
//    List<Product> products = ListGenerators.GetProducts();
//    var sortedProducts = products.OrderByDescending(p => p.UnitsInStock);

//    Console.WriteLine("Products sorted by units in stock (highest to lowest):");
//    foreach (var product in sortedProducts)
//    {
//        Console.WriteLine($"{product.ProductName} - {product.UnitsInStock} units");
//    }
//}

#endregion

#region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

//{
//    string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

//    var sortedDigits = Arr.OrderBy(word => word.Length).ThenBy(word => word);

//    Console.WriteLine("Digits sorted by length, then alphabetically:");
//    foreach (var digit in sortedDigits)
//    {
//        Console.WriteLine(digit);
//    }
//}

#endregion

#region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.

//{
//    string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

//    var sortedWords = words
//        .OrderBy(word => word.Length)
//        .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

//    Console.WriteLine("Words sorted by length, then case-insensitively:");
//    foreach (var word in sortedWords)
//    {
//        Console.WriteLine(word);
//    }
//}

#endregion

#region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

//{
//    List<Product> products = ListGenerators.GetProducts();

//    var sortedProducts = products
//        .OrderBy(p => p.Category)
//        .ThenByDescending(p => p.UnitPrice);

//    Console.WriteLine("Products sorted by category, then by unit price (highest to lowest):");
//    foreach (var product in sortedProducts)
//    {
//        Console.WriteLine($"{product.Category} - {product.ProductName}: ${product.UnitPrice}");
//    }
//}

#endregion

#region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array

//{
//    string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

//    var sortedWords = Arr
//        .OrderBy(word => word.Length)
//        .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

//    Console.WriteLine("Words sorted by length, then case-insensitively in descending order:");
//    foreach (var word in sortedWords)
//    {
//        Console.WriteLine(word);
//    }
//}

#endregion

#region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array

//{
//    string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

//    var filteredReversedDigits = Arr
//        .Where(word => word.Length > 1 && word[1] == 'i')
//        .Reverse();

//    Console.WriteLine("Digits whose second letter is 'i', reversed from original order:");
//    foreach (var digit in filteredReversedDigits)
//    {
//        Console.WriteLine(digit);
//    }
//}

#endregion

#endregion






#region LINQ – Transformation Operators
#region 1. Return a sequence of just the names of a list of products

//{
//    List<Product> products = ListGenerators.GetProducts();

//    var productNames = products.Select(p => p.ProductName);

//    Console.WriteLine("Product names:");
//    foreach (var name in productNames)
//    {
//        Console.WriteLine(name);
//    }
//}

#endregion

#region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

//{
//    string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

//    var wordVariants = words.Select(word => new
//    {
//        Original = word,
//        UpperCase = word.ToUpper(),
//        LowerCase = word.ToLower()
//    });

//    Console.WriteLine("Uppercase and lowercase versions of each word:");
//    foreach (var variant in wordVariants)
//    {
//        Console.WriteLine($"Original: {variant.Original}, Uppercase: {variant.UpperCase}, Lowercase: {variant.LowerCase}");
//    }
//}

#endregion

#region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

//{
//    List<Product> products = ListGenerators.GetProducts();

//    var productProperties = products.Select(p => new
//    {
//        p.ProductName,
//        p.Category,
//        Price = p.UnitPrice,
//        p.UnitsInStock
//    });

//    Console.WriteLine("Product properties (with UnitPrice renamed to Price):");
//    foreach (var product in productProperties)
//    {
//        Console.WriteLine($"Product: {product.ProductName}, Category: {product.Category}, Price: ${product.Price}, Units in stock: {product.UnitsInStock}");
//    }
//}

#endregion

#region 4. Determine if the value of ints in an array match their position in the array.

//{
//    int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//    var result = Arr.Select((num, index) => new
//    {
//        Number = num,
//        InPlace = num == index
//    });

//    Console.WriteLine("Number: In-place?");
//    foreach (var item in result)
//    {
//        Console.WriteLine($"{item.Number}: {item.InPlace}");
//    }
//}

#endregion

#region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

//{
//    int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
//    int[] numbersB = { 1, 3, 5, 7, 8 };

//    var pairs = from a in numbersA
//                from b in numbersB
//                where a < b
//                select new { A = a, B = b };

//    Console.WriteLine("Pairs where a < b:");
//    foreach (var pair in pairs)
//    {
//        Console.WriteLine($"{pair.A} is less than {pair.B}");
//    }
//}

#endregion

#region 6. Select all orders where the order total is less than 500.00

//{
//    List<Order> orders = ListGenerators.GetOrders();

//    var filteredOrders = orders.Where(order => order.OrderTotal < 500.00);

//    Console.WriteLine("Orders with total less than 500.00:");
//    foreach (var order in filteredOrders)
//    {
//        Console.WriteLine($"Order ID: {order.OrderID}, Total: ${order.OrderTotal}");
//    }
//}

#endregion

#region 7. Select all orders where the order was made in 1998 or later.

//{
//    List<Order> orders = ListGenerators.GetOrders();

//    var filteredOrders = orders.Where(order => order.OrderDate.Year >= 1998);

//    Console.WriteLine("Orders made in 1998 or later:");
//    foreach (var order in filteredOrders)
//    {
//        Console.WriteLine($"Order ID: {order.OrderID}, Order Date: {order.OrderDate.ToShortDateString()}");
//    }


#endregion
#endregion















