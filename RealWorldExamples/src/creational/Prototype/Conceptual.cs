namespace RealWorldExamples.src.creational.Prototype
{
    //The Prototype Abstract Class
    //This is an abstract class which is used for the types of object that can be cloned itself.
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Type { get; set; }
        public abstract Employee GetClone();
        public abstract void ShowDetails();
    }
    //This is a class that implements the Prototype interface for cloning itself.
    public class PermanentEmployee : Employee
    {
        public int Salary { get; set; }
        public override Employee GetClone()
        {
            // MemberwiseClone Method Creates a shallow copy of the current System.Object
            // So typecast the Object Appropriate Type
            // In this case, typecast to PermanentEmployee type
            return (PermanentEmployee)this.MemberwiseClone();
        }
        public override void ShowDetails()
        {
            Console.WriteLine("Permanent Employee");
            Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, Salary: {this.Salary}\n");
        }
    }

    //This is a class that implements the Prototype interface for cloning itself.
    public class TemporaryEmployee : Employee
    {
        public int FixedAmount { get; set; }
        public override Employee GetClone()
        {
            // MemberwiseClone Method Creates a shallow copy of the current System.Object
            // So typecast the Object Appropriate Type
            // In this case, typecast to TemporaryEmployee type
            return (TemporaryEmployee)this.MemberwiseClone();
        }
        public override void ShowDetails()
        {
            Console.WriteLine("Temporary Employee");
            Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, FixedAmount: {this.FixedAmount}\n");
        }
    }



    class RunPrototypeProgram
    {
        public static void Main()
        {
            // Creating an Instance of Permanent Employee Class
            Employee emp1 = new PermanentEmployee()
            {
                Name = "Anurag",
                Department = "IT",
                Type = "Permanent",
                Salary = 100000
            };
            //Creating a Clone of the above Permanent Employee
            Employee emp2 = emp1.GetClone();
            // Changing the Name and Department Property Value of emp2 instance, 
            // will not change the Name and Department Property Value of the emp1 instance
            emp2.Name = "Pranaya";
            emp2.Department = "HR";
            emp1.ShowDetails();
            emp2.ShowDetails();
            // Creating an Instance of Temporary Employee Class
            Employee emp3 = new TemporaryEmployee()
            {
                Name = "Preety",
                Department = "HR",
                Type = "Temporary",
                FixedAmount = 200000
            };
            //Creating a Clone of the above Temporary Employee
            Employee emp4 = emp3.GetClone();
            // Changing the Name and Department Property Value of emp4 instance, 
            // will not change the Name and Department Property Value of the emp3 instance
            emp4.Name = "Priyanka";
            emp4.Department = "Sales";
            emp3.ShowDetails();
            emp4.ShowDetails();

            Console.Read();
        }
    }
}
