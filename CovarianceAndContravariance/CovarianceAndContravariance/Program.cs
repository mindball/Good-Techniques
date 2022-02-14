using CovarianceAndContravariance.Contravariant;
using CovarianceAndContravariance.Covariant;
using CovarianceAndContravariance.Delegates;
using CovarianceAndContravariance.OtherTutorial;
using CovarianceAndContravariance.OtherTutorial.ContravarianceInGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContraVariant<Object> iobj = new Sample<Object>();
            IContraVariant<String> istr = new Sample<String>();
            istr = iobj;
            iobj.Val = 1;
            Console.WriteLine($"{iobj.Val} {(iobj.Val.GetType().Name)}");
            istr.Val = 2.2;
            Console.WriteLine($"{istr.Val} {(istr.Val.GetType().Name)}");



            ICovariant<Object> obj = new Example<Object>();
            ICovariant<String> str = new Example<String>();

            obj = str;
            obj.Val = 2;
            Console.WriteLine($"{obj.Val} {(obj.Val.GetType().Name)}");
            str.Val = 3;
            Console.WriteLine($"{str.Val} {(str.Val.GetType().Name)}");
            ;

            //Other Tutorial example
            /* Covariance applies to generic parameters type used as method return type. The type parameter T of the 
             * IEnumerable<out T> is covariant because it is declared with an out keyword. This means that an IEnumerable<Derived> 
             * reference can be assigned to an IEnumerable<Base> reference:             
             */

            IEnumerable<CheckingAccount> derivedAccounts = new List<CheckingAccount>();
            //Enumerable<CheckingAccount> assignment to IEnumerable<Account> is valid because through IEnumerable<T>,
            //elements of type T are always gathered-out and never assigned-in
            IEnumerable<Account> accounts = derivedAccounts;

            //Contravariance in Generics
            //In the code sample below the class AccountComparer implements IComparer<Account>. But because IComparer<in T> is
            //declared with in, T is contravariant. This is why a IComparer<Account> reference can be assigned to a
            //IComparer<CheckingAccount> reference.
            IComparer<AccountTwo> comparer1 = new AccountComparer();
            IComparer<CheckingAccountTwo> comparer2 = comparer1;
            var personOne = new CheckingAccountTwo("Lena", "12SD-ASD22-WWRE-AA32");
            var personTwo = new CheckingAccountTwo("Paul", "12SD-ASD22-WWRE-AA32");

            if (comparer2.Compare(personOne,personTwo) == 0)
            {
                Console.WriteLine("Both checking accounts belongs to same Person!");
            }

            //IComparer<Account> assignment to IComparer<CheckingAccount> is safe because within the context of
            //the interface IComparer<in T>, elements of type T are always assigned-in and never gathered-out.
            //Thus there is no risk of gathering a SavingAccount object from a IComparer<CheckingAccount> comparer

            //Covariance in Array
            CheckingAccount[] array = { new CheckingAccount() };
            Account[] array2 = array; //Not safe
            //Throw run time exceptions InvalidCastException 
            //array2[0] = new SavingAccount();

            //Covariance and Contravariance in Delegates

            //Action with  contravariant parameter types.
            Action<IAccountDelegate> actionOne = (target) => { Console.WriteLine($"{target.GetType().Name} {target.Name}"); };
            Action<CheckingAccountDelegate> actionTwo = actionOne;            
            actionTwo(new CheckingAccountDelegate("Bla"));

            //Func with covariance
            Func<CheckingAccountDelegate> funcOne = () => new CheckingAccountDelegate("Lena");
            Func<IAccountDelegate> funcTwo = funcOne;
            IAccountDelegate account = funcTwo();
            Console.WriteLine(account.Name);
            ;
        }
    }

    /// <Code>
    /// public interface IComparer<in T>
    /// {
    ///     int Compare(T x, T y);     
    /// }
    /// </code>
    class AccountComparer : IComparer<AccountTwo>
    {
        public int Compare(AccountTwo x, AccountTwo y)
        {
            return string.CompareOrdinal(x.SSN, y.SSN);
        }
    }

    public interface II<in TIn, out TOut>
    {
        //invalid variance
        //TIn Method(TOut parameter);

        TOut MethodTwo(TIn parameter);
    }
}
