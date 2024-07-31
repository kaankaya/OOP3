using OOP3;

class Program
{
    static void Main(string[] args)
    {
        //Parametre Almayan Constructor
        Book bk = new Book();
        Console.WriteLine("*******************");
        //Parametre Alan Constructor
        Book bkc = new Book("Adı Aylin","Ayşe","Kulin",398,"Remzi Kitabevi");
        //Kitapları Listeleyen Method
        bkc.ShowBook();
       
        
    }

    
}