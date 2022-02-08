# Implicit and Explicit Operators
Used resources [Tiago Martins](https://blog.devgenius.io/implicit-and-explicit-operators-c-30d28fb573e0).

```
User-defined conversions are not considered by the 'is' and 'as' operators. Use a cast expression to invoke a user-defined explicit conversion.
```

```
Sometimes you need to convert some objects to another type. For instance, when you 
want to map a domain entity to its DTO (Data Transfer Object). Imagine that you have 
30 domain entities and another 30 DTO entities, one for each domain entity. You will 
have a method for each type of entity to convert those objects to its DTO. This would 
be the first option that I would think.
```

## Used cases
