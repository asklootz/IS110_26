namespace Lab5;

/*
Øvelse 2:
Del 1:
Lag en klasse Product med:
    Id (int)
    Name (string)
    Category (string)
    Price (decimal)
*/
class Product
{
    public int id { get; set; }
    public string name  { get; set; }
    public string category  { get; set; }
    public decimal price  { get; set; }

    public Product(int id, string name, string category, decimal price)
    {
        // Konstruktør
        this.id = id;
        this.name = name;
        this.category = category;
        this.price = price;
    }
    
}
