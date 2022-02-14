# Covariance and Contravariance
```
Covariance preserves assignment compatibility and contravariance reverses it.
```

[tutorial1](https://blog.ndepend.com/covariance-and-contravariance-in-csharp-explained/)
[tutorial2](https://www.teixeira-soft.com/bluescreen/2016/03/01/c-understanding-in-and-out-generic-modifier/)
[tutorial3](https://blog.ndepend.com/covariance-and-contravariance-in-csharp-explained/)


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

## Contravariance in Generics As a rule of thumb:
> A covariant generic type parameter (out) can be used as methods return type.
> A contravariant generic type parameters (in) can be used as methods parameter types.
> Variance of multiple generic type parameters are independent. A generic interface or 
> generic delegate type can have both covariant and contravariant type parameters.


## Covariance in Array
```
Covariance and Contravariance in C# provide flexibility for matching a delegate type with a method signature.
Covariance permits a method to have a return type that is a subtype of the one defined in the delegate.
Contravariance permits a method to have a parameter type that is a base type of the one defined in the delegate type.
```
```
Func<T, TResult>  to Func<T1,T2,…T16,TResult> have a covariant return type and contravariant parameter types. 
Thus these generic delegates are declared this way with the in and out keywords:C# 
public delegate TResult Func<in T,out TResult>(T arg);

The same way Action<T> to  Action<T1, T2,….T16> have contravariant parameter types.

```