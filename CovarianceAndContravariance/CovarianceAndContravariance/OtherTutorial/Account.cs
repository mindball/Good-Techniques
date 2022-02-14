using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance.OtherTutorial
{
    /// <summary>
    /// Here are some remarks:
    /// Inheritance:  CheckingAccount and SavingAccount both inherit from base class Account.
    /// 
    /// </summary>
    public class Account
    {        
    }


    /// <summary>
    /// Subtyping :  A CheckingAccount reference or a SavingAccount reference can be assigned to an 
    /// Account reference thanks to subtyping principles. This remark has two opposite consequences:
    ///     A) If a method has an input parameter of type Account, the caller can pass an instance of SavingAccount or CheckingAccount as input
    ///     B) If a method has an Account return type, it can return a SavingAccount object or a CheckingAccount object. 
    ///     If this method is virtual and is overridden in a derived class, the override method can return an Account reference. 
    ///     Alternatively since C#9 the override method can also safely returns a SavingAccount or a CheckingAccount reference, 
    ///     the code below is valid. 
    /// </summary>
    public class CheckingAccount : Account { }

    public class SavingAccount : Account { }

}
