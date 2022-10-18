using System.Reflection.Metadata.Ecma335;

namespace classlib;

public class ContactTest
{
    public Contacts Ctacts { get; init; }

    public ContactTest()
    {
        Ctacts = new Contacts();
        RunTests();
    }

    void RunTests()
    {
        int successes = 0;
        if (TestGetAll() == true)
        {
            successes += 1;
            Console.WriteLine("Test Passed - Get All");            
        }
        else
        {
            Console.WriteLine("Test Failed - Get All");
        }

        if (TestGet() == true)
        {
            successes += 1;
            Console.WriteLine("Test Passed - Get By ID");            
        }
        else
        {
            Console.WriteLine("Test Failed - Get By ID");
        }
        if (TestPost() == true)
        {
            successes += 1;
            Console.WriteLine("Test Passed - Post");            
        }
        else
        {
            Console.WriteLine("Test Failed - Post");
        }
        if (TestDelete() == true)
        {
            successes += 1;
            Console.WriteLine("Test Passed - Delete");            
        }
        else
        {
            Console.WriteLine("Test Failed - Delete");
        }

        Console.WriteLine($"{successes} tests passed");
    }
    public bool TestGetAll()
    {
        try
        {
            foreach(Contact _contact in Ctacts.Get())
            {
                Console.WriteLine(_contact.ToString());
                
            }
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
             
        }

        return false;
    }

    public bool TestGet()
    {
        try
        {
            if (Ctacts.Get(1).FirstName == "Barny")
            {
                Console.WriteLine(Ctacts.Get(1).ToString());
                return true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return false;
    }

    public bool TestPost()
    {
        int ts =0;
        try
        {
            if (Ctacts.Add(new Contact(16, "Jevon", "Voelker", 1234567890, "Jevon Jevon Jevon jevon Jevon")) == true)
            {
                ts += 1;
                if (Ctacts.Get(16).FirstName == "Jevon")
                {
                    Console.WriteLine(Ctacts.Get(16).ToString());
                    ts += 1;
                }
            }

            if (ts == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return false;
    }

    public bool TestDelete()
    {
        try
        {
            Ctacts.Delete(16);
            return true;
        }
        catch (Exception err)
        {
            Console.WriteLine(err);
        }

        return false;
    }
    
    
    
    
}