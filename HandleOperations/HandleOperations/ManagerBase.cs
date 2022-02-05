using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HandleOperations
{
    /// <summary>
    /// Repeating logic. 
    /// For example, instead of throwing the same еxceptions in each 
    /// classmanager, this is the place to implement.
    /// </summary>
    public class ManagerBase
    {
        /// <summary>
        /// Operation without return
        /// </summary>
        /// <param name="codetoExecute"></param>
        /// <exception cref="FaultException"></exception>
        protected void ExecuteFaultHandledOperation(Action codetoExecute)
        {
            try
            {
                codetoExecute.Invoke();
            }
            //catch (SomeCustome ex)
            //{
            //    throw new FaultException<AuthorizationValidationException>(ex, ex.Message);
            //}
            catch (FaultException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// With return generic return type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="codetoExecute"></param>
        /// <returns></returns>
        /// <exception cref="FaultException"></exception>
        protected T ExecuteFaultHandledOperation<T>(Func<T> codetoExecute)
        {
            try
            {
                return codetoExecute.Invoke();
            }
            //some other exception
            //catch (AuthorizationValidationException ex)
            //{
            //    throw new FaultException<AuthorizationValidationException>(ex, ex.Message);
            //}
            catch (FaultException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
