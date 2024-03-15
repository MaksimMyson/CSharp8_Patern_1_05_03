namespace CSharp8_Patern_1_05_03
{
    abstract class Button
    {
        public abstract void Display();
    }

    abstract class TextBox
    {
        public abstract void Display();
    }

    
    class WindowsButton : Button
    {
        public override void Display()
        {
            Console.WriteLine("Displaying Windows Button");
        }
    }

    class WindowsTextBox : TextBox
    {
        public override void Display()
        {
            Console.WriteLine("Displaying Windows TextBox");
        }
    }

    
    class MacOSButton : Button
    {
        public override void Display()
        {
            Console.WriteLine("Displaying MacOS Button");
        }
    }

    class MacOSTextBox : TextBox
    {
        public override void Display()
        {
            Console.WriteLine("Displaying MacOS TextBox");
        }
    }

    
    abstract class GUIFactory
    {
        public abstract Button CreateButton();
        public abstract TextBox CreateTextBox();
    }

    
    class WindowsFactory : GUIFactory
    {
        public override Button CreateButton()
        {
            return new WindowsButton();
        }

        public override TextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }

    class MacOSFactory : GUIFactory
    {
        public override Button CreateButton()
        {
            return new MacOSButton();
        }

        public override TextBox CreateTextBox()
        {
            return new MacOSTextBox();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GUIFactory factory;

        
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                factory = new WindowsFactory();
            else
                factory = new MacOSFactory();

           
            Button button = factory.CreateButton();
            TextBox textBox = factory.CreateTextBox();

            
            button.Display();  
            textBox.Display(); 
        }
    }
}
