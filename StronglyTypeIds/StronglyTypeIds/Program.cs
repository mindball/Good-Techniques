using StronglyTypeIds.Models;
using StronglyTypeIds.Models.StrongTypesIds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;

namespace StronglyTypeIds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var order = new Order() { OrderId = OrderId.New(), RequareInvoice = true, Total = 112.50M };
            var ser = JsonConvert.SerializeObject(order);
            var newOrder = JsonConvert.DeserializeObject<Order>(ser);
            var type = newOrder.GetType().Name;
            ;

            var getOrderConverter = TypeDescriptor.GetConverter(order);
            bool canConvert = getOrderConverter.CanConvertFrom(null, typeof(string));
            if (canConvert)
            {
                var convertOrder = (OrderId)getOrderConverter.ConvertFrom(ser);
                
            }


        }
    }
}
