using System;
using System.Collections.Generic;

abstract class Delivery
{
    public string Address;

    public Delivery(string address)
    {
        Address = address;
    }

    public abstract void ShowInfo();
}

class HomeDelivery : Delivery
{
    public string CourierName;

    public HomeDelivery(string address, string courier)
        : base(address)
    {
        CourierName = courier;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Курьер: {CourierName}, адрес: {Address}");
    }
}

class PickPointDelivery : Delivery
{
    public string PickPointName;

    public PickPointDelivery(string address, string pointName)
        : base(address)
    {
        PickPointName = pointName;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Пункт выдачи: {PickPointName}, адрес: {Address}");
    }
}

class ShopDelivery : Delivery
{
    public string ShopName;

    public ShopDelivery(string address, string shopName)
        : base(address)
    {
        ShopName = shopName;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Магазин: {ShopName}, адрес: {Address}");
    }
}

class Product
{
    public string Name;
    private decimal price;

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value < 0)
                price = 0;
            else
                price = value;
        }
    }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class Order<TDelivery, TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    private List<Product> products = new List<Product>();

    public Order(int number, TDelivery delivery, string description)
    {
        Number = number;
        Delivery = delivery;
        Description = description;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

    public void ShowOrder()
    {
        Console.WriteLine($"Заказ №{Number}");
        Console.WriteLine($"Описание: {Description}");

        Delivery.ShowInfo();

        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - {p.Price}");
        }

        Console.WriteLine($"Итого: {GetTotalPrice()}");
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;

        foreach (var p in products)
        {
            total += p.Price;
        }

        return total;
    }
}

class Program
{
    static void Main()
    {
        var delivery = new HomeDelivery("Москва, Ленина 10", "Иван");

        var order = new Order<HomeDelivery, int>(
            1,
            delivery,
            "Покупка электроники"
        );

        order.AddProduct(new Product("Телефон", 50000));
        order.AddProduct(new Product("Наушники", 5000));

        order.ShowOrder();
    }
}