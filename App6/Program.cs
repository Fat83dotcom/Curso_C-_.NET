using Order;

Product Prod1 = new("Marmita", EProductType.Product);
Product Prod2 = new("Cozinheiro", EProductType.Service);

Console.WriteLine(Prod1.ProductName);
Console.WriteLine(Prod1.Type);
Console.WriteLine(Prod2.ProductName);
Console.WriteLine((int)Prod2.Type);

namespace Order
{
    enum EProductType // Declaração do enumerate.
    {
        Product = 1, // Separar os enumerados por virgulas.
        Service = 2
    }
    struct Product(string name, EProductType type)
    {
        public string ProductName = name;
        public EProductType Type = type;
    }
}
