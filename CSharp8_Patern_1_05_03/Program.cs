namespace CSharp8_Patern_1_05_03
{
    public class Singleton
    {
        
        private static Singleton instance;

        
        private Singleton() { }

       
        public static Singleton GetInstance()
        {
            
            if (instance == null)
            {
                instance = new Singleton(); 
            }
            return instance; 
        }

        
        public void SomeMethod()
        {
            Console.WriteLine("Method of Singleton class is called.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();

            
            if (instance1 == instance2)
            {
                Console.WriteLine("Both instances are the same.");
            }
            else
            {
                Console.WriteLine("Instances are different.");
            }

            
            instance1.SomeMethod();
        }
    }
}
