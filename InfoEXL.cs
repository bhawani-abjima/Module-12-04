using System;

/*var words = new string[] { "Sgt.Ghost", "Sgt.Soap", "Capt.Price", "Sgt.Tim", "Sgt.Mark" };

                                                     // Query syntax
var res = from yu in words
          where yu.Contains('a')
          select yu;

foreach (var yu in res)
{
    Console.WriteLine(yu);
}

Console.WriteLine("............");

                                                         // Method syntax
var res2 = words.Where(ws => word.Contains('a'));

foreach (var word in res2)
{
    Console.WriteLine(word);
}

string[] SS = { "AAfjr", "EErwf", "D43rfwD", "VrwrV", "Gb4rG", "BrrefvB", "vwfsWW" };

Console.WriteLine(SS.ElementAt(2));
Console.WriteLine(SS.First());
Console.WriteLine(SS.Last());

Console.WriteLine(SS.ElementAt(2));
Console.WriteLine(SS.ElementAt(3));
Console.WriteLine(SS.First(jk =>jk.Length == 5));
Console.WriteLine(SS.Last(jk => jk.Length == 6));

int[] PLO = { 1, 2, 3 };

PLO.Prepend(0);
PLO.Append(4);

Console.WriteLine(string.Join(", ", PLO));

var PLO2 = PLO.Prepend(0);
var PLO3 = PLO2.Append(4);

Console.WriteLine(string.Join(", ", PLO3));

User[] users =
{
  new (1, "Chirs", "Greenpark", "2001-04-08"),
  new (2, "Yaris", "Costal island", "1997-01-17"),
  new (3, "Andrew", "Bruce hotel", "1987-12-29"),
  new (4, "Jack", "los theme park", "1936-08-24"),
  new (5, "Tom", "new arena", "1973-11-18"),
  new (6, "Brevis", "open field", "1948-12-23"),
  new (7, "Puke", "mariana island", "2019-12-09"),
  new (8, "Ransom", "B3 amsberg", "2023-05-05"),
  new (9, "Ohio", "lius casino", "2022-01-19"),
};

var YY = from user in users
          where user.City == "open field"
          select new { user.Name, user.City };

Console.WriteLine(string.Join(", ", YY));

record User(int id, string Name, string City, string DateOfBirth);  */


class InfoEXL
{
    class CV
    {
        public void MyMethod() { }
    }

    static void Main(string[] args)
    {
        
        CV mc;
        mc = null;
        mc = new CV();
        mc.MyMethod();

        mc = null;

        string s = null;
        string t = String.Empty;
        bool b = (t.Equals(s));
        Console.WriteLine(b);
        Console.WriteLine("Empty string {0} null string", s == t ? "equals" : "does not equal");
        Console.WriteLine("null == null is {0}", null == null);
        int? i = null;
        System.Console.WriteLine("Press any key to exit.");

        string[] empID = { "YOMO1", "IO-NJ5", "CV-MK6" };
        Console.WriteLine("Displaying elements: ");
        LinkedList<string> VV = new LinkedList<string>(empID);
        foreach (var res in VV)
        {
            Console.WriteLine(res);
        }


        LinkedList<int> UU = new LinkedList<int>();
        UU.AddFirst(84);                                          //creating a linked list
        UU.AddFirst(21);
        UU.AddFirst(60);
        UU.AddLast(04);
        UU.AddLast(92);
        UU.AddLast(101);
        Console.Write("Linked List elements are: ");
        foreach (int f in UU)
        {
            Console.Write(f + " ");
        }


        LinkedList<int> pp = new LinkedList<int>();
        pp.AddFirst(77);                                   //adding elements in linked list
        pp.AddFirst(11);
        pp.AddFirst(33);
        pp.AddLast(404);
        pp.AddLast(001);
        pp.AddLast(603);
        Console.WriteLine("Original: ");
        foreach (int j in pp)
        {
            Console.Write(j + " ");
        }
        pp.RemoveFirst();
        pp.RemoveLast();
        Console.WriteLine();
        Console.WriteLine("After deletion: ");        //deleting from linked list
        foreach (int j in pp)
        {
            Console.Write(j + " ");
        }

        LinkedList<int> dox = new LinkedList<int>();
        dox.AddLast(11);
        dox.AddLast(22);
        dox.AddLast(33);                             //searching in linked list
        dox.AddLast(44);
        dox.AddLast(55);
        dox.AddLast(66);
        Console.Write("Linked List: ");
        foreach (int x in dox)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        Console.WriteLine("The value 3 is present in Linked List: " + dox.Contains(33));
        Console.WriteLine("The value 5 is present in Linked List: " + dox.Contains(55));

        System.Console.ReadKey();
    }
}
