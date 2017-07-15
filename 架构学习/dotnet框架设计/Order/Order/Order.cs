using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    public class Order
    {
        public int Status { get; set; }
        private  Items  items;
        public Items Items
        {
            get
            {
                return this.items;
            }
            set
            {
                if (value.Any(item => item.Price <= 0.0)) //验证商品的价格是否正确
                    return;
                this.items = value;
            }
        }

        private IOperationNormalPrices OperationPrices;

        public Order(IOperationNormalPrices operationPrices)
        {
            this.OperationPrices = operationPrices;
        }


        public double GetPrices()
        {
            return this.OperationPrices.GetPrices(this);
        }
    }
    public class Item
    {
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public virtual double Price { get; set; }
    }

    public class VipItem:Item
    {
        private double price;
        public override double Price
        {
            get
            {
                return base.Price;
            }
            set
            {
                base.Price = value;
            }
        }
    }

    public interface IOperationNormalPrices
    {
        double GetPrices(Order order);
        double GetVipPrice(Order order);
    }
    public class OperationNormalPrices:IOperationNormalPrices
    {

        public double GetPrices(Order order)
        {
            var normalitemList = order.Items.GetNormalItems();
            double result = 0.0;
            foreach (var item in normalitemList)
            {
                result += item.Price;//普通商品直接相加
            }

            var VIPitemList =order.Items.GetVIPItems();
            foreach (var item in VIPitemList)
            {
                result += item.Price + 20;//VIP商品统一下调了20元，所以都需要加上
            }
            return result;
        }

        public double GetVipPrice(Order order)
        {
            double result = 0.0;
            var VIPitemList = order.Items.GetVIPItems();
            foreach (var item in VIPitemList)
            {
                result += item.Price + 20;//VIP商品统一下调了20元，所以都需要加上
            }
            return result;
        }
    }

    public class Items:List<Item>,IEnumerable<Item>
    {
        public Items()
        {
            this.Add(new Item() { ItemCode = "VIP_001", ItemName = "光明牛奶", Price = 36.5 });
            this.Add(new Item() { ItemCode = "Normal_001", ItemName = "红富士苹果", Price = 30.5 });
            this.Add(new Item() { ItemCode = "VIP_002", ItemName = "蒙牛牛奶", Price = 10 });
            this.Add(new Item() { ItemCode = "Normal_002", ItemName = "进口苹果", Price = 60 });
        }

        public IEnumerable<Item> GetVIPItems()
        {
            if (this.Count == 0) return null;
            var result = from item in this where item.ItemCode.StartsWith("VIP") select item;
            return result.ToList();
        }
        public IEnumerable<Item> GetNormalItems()
        {
            if (this.Count == 0) return null;
            var result = from item in this where item.ItemCode.StartsWith("Normal") select item;
            return result.ToList();
        }
    }
}
