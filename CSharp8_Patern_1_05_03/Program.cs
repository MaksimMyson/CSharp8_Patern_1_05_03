namespace CSharp8_Patern_1_05_03
{
    class Pizza
    {
        public string Dough { get; set; } = "default dough";
        public string Sauce { get; set; } = "default sauce";
        public string Topping { get; set; } = "default topping";

        public void Display()
        {
            Console.WriteLine($"Pizza with {Dough} dough, {Sauce} sauce, and {Topping} topping.");
        }
    }

    abstract class PizzaBuilder
    {
        protected Pizza pizza = new Pizza();

        public Pizza GetPizza()
        {
            return pizza;
        }

        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();
    }

    class MargheritaPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.Dough = "thin crust";
        }

        public override void BuildSauce()
        {
            pizza.Sauce = "tomato";
        }

        public override void BuildTopping()
        {
            pizza.Topping = "mozzarella cheese";
        }
    }

    class PepperoniPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.Dough = "thick crust";
        }

        public override void BuildSauce()
        {
            pizza.Sauce = "spicy tomato";
        }

        public override void BuildTopping()
        {
            pizza.Topping = "pepperoni slices";
        }
    }

    class PizzaDirector
    {
        private readonly PizzaBuilder pizzaBuilder;

        public PizzaDirector(PizzaBuilder builder)
        {
            pizzaBuilder = builder;
        }

        public void MakePizza()
        {
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder margheritaBuilder = new MargheritaPizzaBuilder();
            PizzaDirector margheritaDirector = new PizzaDirector(margheritaBuilder);
            margheritaDirector.MakePizza();
            Pizza margheritaPizza = margheritaBuilder.GetPizza();
            margheritaPizza.Display();

            PizzaBuilder pepperoniBuilder = new PepperoniPizzaBuilder();
            PizzaDirector pepperoniDirector = new PizzaDirector(pepperoniBuilder);
            pepperoniDirector.MakePizza();
            Pizza pepperoniPizza = pepperoniBuilder.GetPizza();
            pepperoniPizza.Display();
        }
    }

}

