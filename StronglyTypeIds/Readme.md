# Strongly-type ids
```
Entities typically have integer, GUID or string ids, because those types are supported directly by databases. 
However, if all your entities have ids of the same type, it becomes pretty easy to mix them up, and use 
the id of a Product where the id of an Order was expected. This is actually a pretty common source of bugs.
Strongly-typed IDs can help avoid simple, but hard-to-spot, argument transposition errors. By using the types 
defined in this post, you can get all the benefits of the C# type system, without making your APIs clumsy to use, 
or adding translation code back-and-forth between Guids and your strongly-typed IDs.

The idea is simple: declare a specific type for the id of each entity
```
```
 if you're using an ORM like EF 6, using a struct might cause you problems, so a class might be easier. 
 That also gives the option of creating a base StronglyTypedId class to avoid some of the boiler plate.
```

```
By using strongly-typed IDs like these we can take full advantage of the C# type system to ensure different 
concepts cannot be accidentally used interchangeably. Using these types in the core of your domain will 
help prevent simple bugs like incorrect argument order issues, which can be easy to do, and tricky to spot!
```


```c#
public void AddProductToOrder(int orderId, int productId, int count)
{
    //some code
}

// Oops, the arguments are swapped!
//method invoke with missmath arguments
AddProductToOrder(productId, orderId, int count);
```

## Strongly-typed IDs make for ugly JSON APIs
```
The problem is that our strongly-typed IDs mean that for MVC Model Binding to work as we expect.
To solve this problem for binding create custom JsonConverter.
JsonConverter in Newtonsoft.Json can be used to customise how types are converted to and from JSON. in 
ASP.NET Core 2.x that also allows you to customize how types are serialised and deserialised during model binding.

Note that in ASP.NET Core 3.0 JSON serialization will be changing

```
```c#
[ApiController]
public class OrderController : ControllerBase
{
    [HttpPost]
    public IActionResult Post(Order order);
}
...

public class Order
{
    //StronglyTypeIds
    public OrderId Id { get; set; }
    //StronglyTypeIds
    public UserId UserId { get; set; }
    public decimal Total { get; set; }
}
...
//Json body result
{
    "Id": {
        "Value": "da63f7a0-a4a6-4dbe-a9a4-4bb72dde30dd"
    },
    "UserId": {
        "Value": "4bb20f98-f6d4-43bc-9fdf-5b74ce4ef751"
    },
    "Total": 123.45
}
```

> By using a custom JsonConverter, the serialized Order looks much cleaner and easier to work with:
```json
{
    "Id": "da63f7a0-a4a6-4dbe-a9a4-4bb72dde30dd",
    "UserId": "4bb20f98-f6d4-43bc-9fdf-5b74ce4ef751",
    "Total": 123.45
}
```
