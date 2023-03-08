

using _8mart;

Book[] Books = new Book[2];

for (int i = 0; i < Books.Length; i++)

{
    Console.WriteLine("kitab adi :  );
        string name = Console.ReadLine();
    Console.WriteLine("kitab seyife sayi");
    int page=int.Parse(Console.ReadLine());




    while (!CheckName(name))
    {
        Console.WriteLine("adi duzgun daxil et ");
         name = Console.ReadLine();


    }

    while (!CheckCount(page))
    {
        Console.WriteLine("page duzgun daxil et");
        page = int.Parse(Console.ReadLine());



    }




    Book book = new Book(name, page);

    Books[i] = book;


}


bool CheckName(string name)
{

    if (!string.IsNullOrWhiteSpace(name) && name.Length > 2)
        return true;

    return false;

}


bool CheckCount(int pageCount)
{

    if (pageCount>2)
        return true;

    return false;

}


foreach (Book book in Books)
{

    Console.WriteLine($"Name : {book.Name}  pageCount : {book.PageCount}");


}

