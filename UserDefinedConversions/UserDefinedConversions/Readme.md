# Conversions (User-Defined)
```
A conversion causes an expression to be converted to, or treated as being of, a particular type; 
in the former case a conversion may involve a change in representation. Conversions can be implicit 
or explicit, and this determines whether an explicit cast is required.
```

* [tutorial1](https://www.pluralsight.com/guides/converting-your-own-way-csharp)
* [c# lang specification](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/conversions#processing-of-user-defined-explicit-conversions)
* [c# lang specification](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/classes#14104-conversion-operators)

```
These are widely used conversions in legacy corporate applications that support infrastructure or business logic. 
Basically, with two simple functions, you are able to create your custom class for conversion and C# allows 
you to define your own business logic to implement that.
```

* [tutorial2](https://thesharperdev.com/explaining-implicit-conversion-operators-in-c/)

## Warning
```
While this can be a useful feature, I would argue that being explicit is the better way to go in 
most circumstances.Implicit conversions definitely have a cost to them. It could cause potentially 
subtle bugs or the wrong method to be called. I can’t personally think of a use case where implicit 
conversion saved me enough time to use it.
```