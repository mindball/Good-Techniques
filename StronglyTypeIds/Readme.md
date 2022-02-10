# Strongly-type ids
```
Entities typically have integer, GUID or string ids, because those types are supported directly by databases. 
However, if all your entities have ids of the same type, it becomes pretty easy to mix them up, and use 
the id of a Product where the id of an Order was expected. This is actually a pretty common source of bugs.

The idea is simple: declare a specific type for the id of each entity
```
```c#
public void AddProductToOrder(int orderId, int productId, int count)
{
    //some code
}

...

// Oops, the arguments are swapped!
//method invoke with missmath arguments
AddProductToOrder(productId, orderId, int count);
```
