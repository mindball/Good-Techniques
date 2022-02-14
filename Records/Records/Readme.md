# Records
Records are reference types, just like classes. The main way they differ from classes is when it comes to equality:
* Two records are equal if:
> Definitions are equal (e.g same number/name of properties)
> Values in each of those definitions are equal
```
This behavior can be extremely useful to check if two records have changed, for example, if you’re passing a record 
to a different thread/process and want to see if the values have changed.
```

* On the other hand, two classes are equal if:
> The two objects are of the same class type
> Variables refer to the same object

```
records use value-based equality, whilst classes use memory-based equality.
```
```
When we mark our class or struct as a record, the compiler will generate a bunch of methods for our convenience 
such as overriding the Equals method and several operators.
```

```
Another property on records: built-in formatting display we didn’t have to create a custom .ToString() method to make it nice and readable,
records do this for us! This is a very handy feature that will save us lots of time (and code).
```
```
an implementation for the Deconstruct method, which allows us to use object deconstruction to access individual properties.
```

## Immutability of Records
```
Records are designed to be used for scenarios where immutability is key.

They are also designed to hold data structures and not states.
```
```
read-only properties, which makes an instance of the type immutable without additional work such as defining 
fields or properties with specific keywords.

```


### Init-only Properties
init operator to specify that the properties of the Person record can only be set during initialization.

```
This is probably the key feature to call out. We want to capture the initial state of the data and 
pass it around our app, but we do not want anything modifying it in any way. If we want the record 
similar to the state of another record, however, we can use the special cloning features of records
```

```c#
public record Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }    
}
```

### Positional Records
```c#
//Not compile , while we have constructor with corresponding parameters
var personInitOne = new PersonInit { FirstName = "Joe", LastName = "Bloggs" }; //not compile

```

## Cloning Records
```
When it comes to cloning in .NET, there are usually two possibilities:

Shallow cloning (the members of the copied object refer to the same object as the original object)
Deep cloning (the members of the copied object are completely separate)
```

```
With regular classes, to do a shallow clone we can use the MemberwiseClone() method that is inherited 
from the base Object class. To do a deep clone, we would need to implement ICloneable and do it ourselves 
(perhaps, with some kind of serialization).
```
```
Behind the scenes, the compiler is doing what is called “non-destructive mutation”, where the properties of 
the original record are copied to the new record, but the original record is not mutated in any way, 
keeping with the goal of immutability. 
```

## Inheritance
