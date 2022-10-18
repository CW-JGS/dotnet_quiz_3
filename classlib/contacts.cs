using System.Linq;
namespace classlib;

public class Contacts
{
    public List<Contact> ContactsArr { get; set; }
    public Contacts()
    {
        ContactsArr = new List<Contact>()
        {
            new Contact(1,"Barny","Konig",4301472960,"Multi-tiered foreground info-mediaries"),
            new Contact(2,"Carena","Ridgway",2719863143,"Switchable mobile open system"),
            new Contact(3,"Vanya","Corrison",8858316387,"Horizontal user-facing middleware"),
            new Contact(4, "Letizia", "Jerrams", 8111679514, "Down - sized didactic solution"),
            new Contact(5, "Antonie", "Chifney", 7883232602, "Synchronised bottom-line migration"),
            new Contact(6, "Aristotle", "Lawless", 4968769159, "Down - sized analyzing encryption"),
            new Contact(7, "Aura", "Owain", 6033340795, "Synergized maximized array"),
            new Contact(8, "Toddie", "Morant", 3463150939, "Extended upward-trending secured line"),
            new Contact(9, "Davidde", "Othick", 1686449046, "Centralized intangible website"),
            new Contact(10, "Lila", "Featherbie", 5884269076, "Seamless empowering structure"),
            new Contact(11, "Ramonda", "Benford", 5905589103, "Triple - buffered systemic budgetary management"),
            new Contact(12, "Eli", "Gudgin", 9095862889, "Horizontal full-range website"),
            new Contact(13, "Albie", "Mendez", 6297410487, "Compatible intermediate hub"),
            new Contact(14, "Meridith", "Hollington", 9929530595, "Customer - focused contextually-based archive"),
            new Contact(15, "Christian", "Gorce", 2675647278, "Front - line empowering forecast")
        };
        
    }

    public IEnumerable<Contact> Get()
    {
        return ContactsArr;
    }

    public Contact Get(int id)
    {
        var value = ContactsArr.Where(item => item.ID == id).ToArray();
        return value[0];
    }
    public bool Add(Contact _contact)
    {
        try
        {
            ContactsArr.Add(_contact);
            return true;
        }
        catch (Exception err)
        {
            Console.WriteLine($"[X] - {err}");
        }
        return false;
    }

    public bool Delete(int id)
    {
        try
        {
            ContactsArr.RemoveAll(item => item.ID == id);
            return true;
        }
        catch (Exception err)
        {
            Console.WriteLine(err);
        }

        return false;
    }
    
    
    
    
}
