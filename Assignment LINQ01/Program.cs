using LINQ.DataSources;

namespace Assignment_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //var result = Source.ProductList.Where(p => p.Category == "Seafood");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"ProductName {item.ProductName} ProductPrice {item .UnitPrice}");
            //} 
            #endregion
            #region Q2
            //var result = Source.ProductList.Select(p => p.ProductName);
            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion
            #region Q3
            //var result = Source.ProductList.OrderBy(p => p.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"ProductName{item .ProductName}, UnitPrice {item.UnitPrice }");
            //}
            #endregion
            #region Q4
            //var result = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name {item.ProductName} Price {item .UnitPrice}");
            //}
            #endregion
            #region Q5
            //var result = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "condiments");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name {item .ProductName } In Stock : {item .UnitsInStock} Categery {item .Category}");
            //}
            #endregion
            #region Q6
            //var result = Source.ProductList.Select(p => new
            //{
            //    name = p.ProductName,
            //    price = p.UnitPrice,
            //    StockStutus = p.UnitsInStock > 0 ? "Availble" : "Out of Stock"

            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name {item.name} Price {item .price} Stutus {item .StockStutus}");
            //}

            #endregion
            #region Q7
            //var result = Source.ProductList.Select((p, i) => $"{i + 1}. {p.ProductName}");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q8
            //var result = Source.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Catogory : {item .Category } Price {item .UnitPrice } Name {item .ProductName}");
            //}
            #endregion
            #region Q9
            //var result = Source.ProductList.Where(p => p.Category == "Beverages");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name {item .ProductName} Stock {item .UnitsInStock}");
            //}
            #endregion
            #region Q10
            //var result = from c in Source.CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1997
            //             select new
            //             {
            //                 c.CustomerID,
            //                 o.OrderDate
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Customer Id {item.CustomerID}  Order Date {item .OrderDate :yyyy _MM _dd}");
            //}
            #endregion
            #region Q11
            //var result = Source.ProductList.Select((p, i) => new
            //{
            //    position = i+1,
            //    p.ProductName
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.position} _ {item .ProductName}");
            //}
            #endregion
            #region Q12
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(w => w.Length)
            //    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var Ward in result)
            //{
            //    Console.WriteLine(Ward);
            //}

            #endregion
            #region Q13
            //String[] digits = { "Zero ", "one", "two", "three", "four", "five" ,"six","seven" , "eight", "nine"};
            //var result = digits
            //    .Where(d => d.Length > 1 && d[1] == 'i')
            //.Reverse().ToList();
            //foreach (var digit in result)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion


        }
    }
}
