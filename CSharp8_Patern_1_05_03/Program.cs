namespace CSharp8_Patern_1_05_03
{
    abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    
    class ConcretePrototype : Prototype
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ConcretePrototype(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            ConcretePrototype original = new ConcretePrototype(1, "Original Object");
            Console.WriteLine("Original object: " + original);

           
            ConcretePrototype cloned = (ConcretePrototype)original.Clone();
            Console.WriteLine("Cloned object: " + cloned);

            
            cloned.Id = 2;
            cloned.Name = "Cloned Object";
            Console.WriteLine("Updated cloned object: " + cloned);
        }
    }
}
