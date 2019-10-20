using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }

            public string Description { get; set; }

            public string[] Special { get; set; }

            public MockOrderItem(double price)
            {
                Price = price;
            }
        }

        [Theory]
        [InlineData(1.0, 2.0, 3.0, 4.0, 10.0)]
        [InlineData(5.0, 6.0, 3.5, 4.0, 18.5)]
        [InlineData(3.0, 4.0, 7.0, 1.0, 15.0)]
        public void ShouldHaveCorrectSubtotal(double price1, double price2, double price3, double price4, double sum)
        {
            Order o = new Order(0);
            o.Items.Add(new MockOrderItem(price1));
            o.Items.Add(new MockOrderItem(price2));
            o.Items.Add(new MockOrderItem(price3));
            o.Items.Add(new MockOrderItem(price4));
            Assert.Equal(sum, o.SubtotalCost, 2);
        }

        [Fact]
        public void SubtotalShouldNotBeNegative()
        {
            Order o = new Order(0);
            o.Items.Add(new MockOrderItem(-1.0));
            o.Items.Add(new MockOrderItem(-5.0));
            Assert.Equal(0.00, o.SubtotalCost, 2);
        }

        [Theory]
        [InlineData(1.0, 2.0, 3.0, 4.0, .25, 2.5)]
        [InlineData(5.0, 6.0, 3.5, 4.0, .03, 0.555)]
        [InlineData(3.0, 4.0, 7.0, 1.0, .085, 1.275)]
        public void ShouldHaveCorrectSalesTaxTotal(double price1, double price2, double price3, double price4, double rate, double expect)
        {
            Order o = new Order(rate);
            o.Items.Add(new MockOrderItem(price1));
            o.Items.Add(new MockOrderItem(price2));
            o.Items.Add(new MockOrderItem(price3));
            o.Items.Add(new MockOrderItem(price4));
            Assert.Equal(expect, o.SalesTaxCost, 3);
        }

        [Theory]
        [InlineData(1.0, 2.0, 3.0, 4.0, .25, 12.5)]
        [InlineData(5.0, 6.0, 3.5, 4.0, .03, 19.055)]
        [InlineData(3.0, 4.0, 7.0, 1.0, .085, 16.275)]
        public void ShouldHaveCorrectTotalCost(double price1, double price2, double price3, double price4, double rate, double expect)
        {
            Order o = new Order(rate);
            o.Items.Add(new MockOrderItem(price1));
            o.Items.Add(new MockOrderItem(price2));
            o.Items.Add(new MockOrderItem(price3));
            o.Items.Add(new MockOrderItem(price4));
            Assert.Equal(expect, o.TotalCost, 3);
        }
    }
}
