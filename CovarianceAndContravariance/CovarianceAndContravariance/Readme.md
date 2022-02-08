# Covariance and Contravariance
```
Covariance preserves assignment compatibility and contravariance reverses it.
```

[tutorial1](https://blog.ndepend.com/covariance-and-contravariance-in-csharp-explained/)
[tutorial2](https://www.teixeira-soft.com/bluescreen/2016/03/01/c-understanding-in-and-out-generic-modifier/)

## Contravariance
```
Contravariance enables you to use a less derived type than that specified by the generic parameter.
An interface that has a contravariant type parameter allows its methods to accept arguments of less 
derived types than those specified by the interface type parameter.
```

## Covariance
```
An interface that has a covariant type parameter enables its methods to return more derived types than 
those specified by the type parameter. 
```

```
In a generic interface, a type parameter can be declared covariant if it satisfies the following conditions:
The type parameter is used only as a return type of interface methods and not used as a type of method arguments.
The type parameter is not used as a generic constraint for the interface methods.
```