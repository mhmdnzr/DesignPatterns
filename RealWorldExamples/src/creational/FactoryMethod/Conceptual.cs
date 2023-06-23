using System;

namespace RealWorldExamples.src.creational.FactoryMethod
{
    // The Dialog class declares the factory method that is supposed to return
    // an object of a Product class. The Dialog's subclasses usually provide
    // the implementation of this method.
    abstract class Dialog
    {
        // Note that the Dialog may also provide some default implementation of
        // the factory method.
        public abstract IButton FactoryMethod();

        // Also note that, despite its name, the Dialog's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public string RenderButton()
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();
            // Now, use the product.
            var result = "Dialog: The same Dialog's code has just worked with "
                + product.OnClick();

            return result;
        }
    }

    // Concrete Dialogs override the factory method in order to change the
    // resulting product's type.
    class ConcreteDialog1 : Dialog
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Dialog can stay independent of concrete product
        // classes.
        public override IButton FactoryMethod()
        {
            return new WinButton();
        }
    }

    class ConcreteDialog2 : Dialog
    {
        public override IButton FactoryMethod()
        {
            return new WebButton();
        }
    }

    // The Product interface declares the OnClicks that all concrete products
    // must implement.
    public interface IButton
    {
        string OnClick();
    }

    // Concrete Products provide various implementations of the Product
    // interface.
    class WinButton : IButton
    {
        public string OnClick()
        {
            return "{Result of WinButton}";
        }
    }

    class WebButton : IButton
    {
        public string OnClick()
        {
            return "{Result of WebButton}";
        }
    }

    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteDialog1.");
            ClientCode(new ConcreteDialog1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteDialog2.");
            ClientCode(new ConcreteDialog2());
        }

        // The client code works with an instance of a concrete Dialog, albeit
        // through its base interface. As long as the client keeps working with
        // the Dialog via the base interface, you can pass it any Dialog's
        // subclass.
        public void ClientCode(Dialog Dialog)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the Dialog's class," +
                "but it still works.\n" + Dialog.RenderButton());
            // ...
        }
    }

    public class RunFactoryMethodProgram
    {
        public static void Main()
        {
            new Client().Main();
        }
    }
}