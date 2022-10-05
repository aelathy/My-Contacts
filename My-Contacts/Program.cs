// My-Contacts Assignment
#nullable disable
Console.Clear();

contact acc1 = new contact()
{
    name = "Aly",
    num = "780-213-5321",
    email = "a.elathy@share.epsb.ca"
};
contact acc2 = new contact()
{
    name = "Joe",
    num = "780-231-2354",
    email = "joe@gmail.com"
};
contact acc3 = new contact()
{
    name = "John",
    num = "780-213-2352",
    email = "john@hotmail.com"
};
contact acc4 = new contact()
{
    name = "Mo",
    num = "587-213-5321",
    email = "Mo@joe.ca"
};

// List
List<contact> contactList = new List<contact> { acc1, acc2, acc3, acc4 };

// Linebreak
void br()
{
    Console.WriteLine();
}



// While loop
bool loop = true;
while (loop)
{
    // Main Menu Loop
    Console.WriteLine("\n Main Menu");
    Console.WriteLine("1. Display Contact Names");
    Console.WriteLine("2. Search for Contact");
    Console.WriteLine("3. Edit Contact");
    Console.WriteLine("4. New Contact");
    Console.WriteLine("5. Remove Contact");
    Console.WriteLine("6. Exit");
    Console.Write("Please enter # option from the main menu: ");
    string menuOption = Console.ReadLine();
    br();


    if (menuOption == "1")
    {
        foreach (contact c in contactList)
        {
            Console.WriteLine(c.name + " " + c.num + " " + c.email);
        }
    }
    else if (menuOption == "2")
    {
        var result = false;
        Console.Write("Which contact are you looking for? ");
        string contactSearched = Console.ReadLine();
        foreach (contact c in contactList)
        {
            if (contactSearched == c.name)
            {
                Console.WriteLine($"{c.name} is in your contact list.");
                result = true;
            }
        }
        if (!result)
        {
            Console.WriteLine($"{contactSearched} was NOT found in your contact list.");
        }

    }
    else if (menuOption == "3")
    {
        var result = false;
        Console.Write("Which contact do you want to edit? ");
        string contactSearched = Console.ReadLine();
        foreach (contact c in contactList)
        {
            if (contactSearched == c.name)
            {
                Console.WriteLine($"{c.name} is in your contact list.");
                br();
                Console.WriteLine($"Edit the name, number, and email below.");
                br();
                Console.Write("Please enter the new name of the account: ");
                string nameChange = Console.ReadLine();
                Console.Write("Please enter the new number of the account: ");
                string numChange = Console.ReadLine();
                Console.Write("Please enter the new email of the account: ");
                string emailChange = Console.ReadLine();
                c.name = nameChange;
                c.num = numChange;
                c.email = emailChange;
                Console.WriteLine(c.name + " " + c.num + " " + c.email);
                result = true;
                break;
            }
        }
        if (!result)
        {
            Console.WriteLine($"{contactSearched} was NOT found in your contact list.");
        }

    }
    else if (menuOption == "4")
    {
        Console.Write("Please enter a new contact you would like to add: ");
        string newName = Console.ReadLine();
        Console.Write("Please enter the number of this new contact: ");
        string newNum = Console.ReadLine();
        Console.Write("Please enter the email of this new contact: ");
        string newEmail = Console.ReadLine();
        contactList.Add(new contact() { name = newName, num = newNum, email = newEmail });
        Console.WriteLine(contactList.Last().name + " " + contactList.Last().num + " " + contactList.Last().email);
    }
    else if (menuOption == "5")
    {
        var result = false;
        Console.Write("Please enter a contact in the list you would like to remove: ");
        string contactSearched = Console.ReadLine();
        foreach (contact c in contactList)
        {
            if (contactSearched == c.name)
            {
                contactList.Remove(c);
                Console.WriteLine($"{c.name} was removed from your contact list.");
                result = true;
                break;
            }
        }
        if (!result)
        {
            Console.WriteLine($"{contactSearched} was NOT found in your contact list.");
        }
    }
    else if (menuOption == "6")
    {
        break;
    }
}

public class contact
{
    public string name { get; set; }
    public string num { get; set; }
    public string email { get; set; }
}