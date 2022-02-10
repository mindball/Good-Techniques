using System;
using Xunit;
using StronglyTypeIdsNewVersion.Models.StrongTypesIds;

namespace StronglyTypes.Test
{
    public class UnitTest1
    {
        [Fact]
        public void SameValuesAreEqual()
        {
            var id = Guid.NewGuid();
            var orderOne = new OrderId(id);
            var orderTwo = new OrderId(id);

            Assert.Equal(orderOne, orderTwo);
        }

        [Fact]
        public void DifferentValuesAreUnequal()
        {
            var orderOne = OrderId.New();
            var orderTwo = OrderId.New();

            Assert.NotEqual(orderOne, orderTwo);
        }

        [Fact]
        public void OperatorsWorkCorrectly()
        {
            var id = Guid.NewGuid();
            var same1 = new OrderId(id);
            var same2 = new OrderId(id);
            var different = OrderId.New();

            Assert.True(same1 == same2);
            Assert.True(same1 != different);
            Assert.False(same1 == different);
            Assert.False(same1 != same2);
        }
    }
}