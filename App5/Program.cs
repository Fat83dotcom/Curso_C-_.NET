using Order;

Product order1 = new(828, "manteiga", "Passa no Pão", 14.89f);
Product order2 = new(541, "Pão de queijo", "Quitute", 25.89f);
Product order3 = new(154, "Rosca Frita", "Quitute", 34.69f);
Product order4 = new(951, "Todynho", "Leite de Caixinha", 4.99f);

Console.WriteLine(order1.DiscountPerCent(20));
Console.WriteLine(order2.DiscountPerCent(50));
Console.WriteLine(order3.DiscountPerCent(15));
Console.WriteLine(order4.DiscountPerCent(8));

namespace Order
{
    public struct Product(int id, string name, string description, float price)
    {
        public int Id = id;
        public string Name = name;
        public string Description = description;
        public float Price = price;

        public float DiscountPerCent(float rate)
        {
            float tax = Price -= (rate * Price) / 100;
            return tax;
        }
    }
}