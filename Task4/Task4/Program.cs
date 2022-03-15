#define DEBUG

using Task4;

public class Program
{
    public static void Main()
    {
        var message = "The main method has ended";
        try
        {
            testCases(null, null, 10);
            Console.WriteLine("The parameters are correct");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.ToString());
        }

        try
        {
            testCases("", null, 10);
            Console.WriteLine("The parameters are correct");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.ToString());
        }

        try
        {
            testCases("productName", null, 10);
            Console.WriteLine("The parameters are correct");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.ToString());
        }

        try
        {
            testCases("productName", "", 10);
            Console.WriteLine("The parameters are correct");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.ToString());
        }

        try
        {
            testCases("productName", "productDescription", 10);
            Console.WriteLine("The parameters are correct");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.ToString());
        }

        Foo();
        Console.WriteLine(message);
    }

#if DEBUG
    private static void Foo()
    {
        Console.WriteLine("I reached this method");
    }
#endif

    private static Product createProduct(string name, string description, double price)
    {
        if (name == null)
            throw new ArgumentNullException ("Name must not be null");
        if (name.Length == 0 || name[0] < 'A')
            throw new InvalidNameException ("Name must not be empty or begin with lowercase letter");
        if (description == null)
            throw new ArgumentNullException ("Description must not be null");
        if (description.Length == 0)
            throw new InvalidDescriptionException("Description must not be empty");
        Product product = new Product (name, description, price);
        return product;
    }

    private static void testCases(string name, string description, double price)
    {
        Product product = null;
        try
        {
            product = createProduct(name, description, price);

        }
        catch (ArgumentNullException argumentNullException)
        {
            throw new Exception("You gave a null parameter", argumentNullException);
        }
        catch (InvalidNameException invalidNameException)
        {
            throw new Exception("The name you gave is invalid", invalidNameException);
        }
        catch (InvalidDescriptionException invalidDescriptionException)
        {
            throw new Exception("The description you gave is invalid", invalidDescriptionException);
        }
        finally
        {
            if (product != null)
                Console.WriteLine("The product you gave is ", product);
        }
    }
}
