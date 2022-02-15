// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using RecordsAsStronglyTypes.Entities;
using RecordsAsStronglyTypes.StronglyTypedIds;

Console.WriteLine("Hello, World!");

var newProductId = new ProductId(Guid.NewGuid());
var newProduct = new Product()
{
    Id = newProductId,
    Name = "Laptop",
    UnitPrice = 1132.22M
};

var ser = JsonConvert.SerializeObject(newProduct);

var unSer = JsonConvert.DeserializeObject<Product>(ser);
;
