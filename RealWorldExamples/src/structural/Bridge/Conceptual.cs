namespace RealWorldExamples.src.structural.Bridge
{
    // The Remote defines the interface for the "control" part of the two
    // class hierarchies. It maintains a reference to an object of the
    // Implementation hierarchy and delegates all of the real work to this
    // object.
    class Remote
    {
        protected IImplementation _implementation;

        public Remote(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                _implementation.OperationImplementation();
        }
    }

    // You can extend the Remote without changing the Implementation
    // classes.
    class TVRemote : Remote
    {
        public TVRemote(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "TVRemote: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }

    class RadioRemote : Remote
    {
        public RadioRemote(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "RadioRemote: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }

    // The Implementation defines the interface for all implementation classes.
    // It doesn't have to match the Remote's interface. In fact, the two
    // interfaces can be entirely different. Typically the Implementation
    // interface provides only primitive operations, while the Remote
    // defines higher- level operations based on those primitives.
    public interface IImplementation
    {
        string OperationImplementation();
    }

    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.
    class TV : IImplementation
    {
        public string OperationImplementation()
        {
            return "TV: The result in TV.\n";
        }
    }

    class Radio : IImplementation
    {
        public string OperationImplementation()
        {
            return "Radio: The result in Radio.\n";
        }
    }

    class Client
    {
        // Except for the initialization phase, where an Remote object gets
        // linked with a specific Implementation object, the client code should
        // only depend on the Remote class. This way the client code can
        // support any abstraction-implementation combination.
        public void ClientCode(Remote abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }

    class RunBridgeProgram
    {
        public static void Main()
        {
            Client client = new Client();

            Remote abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new RadioRemote(new Radio());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new TVRemote(new TV());
            client.ClientCode(abstraction);
        }
    }
}
