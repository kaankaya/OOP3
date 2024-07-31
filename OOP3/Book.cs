using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class Book
    {
        //Değişkenlerimizi private erişim yöntemi ile dışarıya kapataıyoruz
        private string _bookName;
        private string _authorName;
        private string _authorSurname;
        private int _numberPages;
        private string _publisher;
        private DateTime _registrationDate;
       
        //Parametre almayan Constructor Tanımlıyoruz.Sadece Otomatik olarak Kayıt Tarihini oluşturuyor.
        public Book() 
        {
            //kayıt tarihi için datetime.now ile şuan ki zamanı alıyoruz
            _registrationDate = DateTime.Now;
            //ToString ile Kayıt Tarihini Formatlıyoruz
            Console.WriteLine($"Kayıt Tarihi : {RegistrationDate.ToString("dd/MM/yyyy")}");
        }
        //Parametre Alan Constructor Tanımlıyoruz
        public Book(string bookName, string authorName, string authorSurname, int numberPages, string publisher)
        {
            _registrationDate = DateTime.Now;
            _bookName = bookName;
            _authorName = authorName;
            _authorSurname = authorSurname;
            _numberPages = numberPages;
            _publisher = publisher;
            RegistrationDate.ToString("dd/MM/yyyy");

        }
        //Property Atamalarını Gerçekleştiriyoruz
        public string BookName 
        { 
            get => _bookName;
            set => _bookName = value;
        }
        public string AuthorName 
        { 
            get => _authorName;
            set => _authorName = value;
        }
        public string AuthorSurname 
        {
            get => _authorSurname;
            set => _authorSurname = value;
        }
        public int NumberPages 
        {
            get => _numberPages;
            set => _numberPages = value;
        }
        public string Publisher 
        { 
            get => _publisher;
            set => _publisher = value;
        }

        public DateTime RegistrationDate 
        {
            get => _registrationDate;
            set => _registrationDate = value;
        }
       //Listeleme için Methodu muzu tanımlıyoruz. ToString ile kayıt tarihini otomatik oluşturuyoruz.Verilerimizi Propertylerden çekiyoruz
        public void ShowBook()
        {
            Console.WriteLine($"Kitap Adı: {BookName}");
            Console.WriteLine($"Yazar Adı: {AuthorName}");
            Console.WriteLine($"Yazar Soyadı : {AuthorSurname}");
            Console.WriteLine($"Sayfa Sayısı : {NumberPages}");
            Console.WriteLine($"Yayın Evi : {Publisher}");
            Console.WriteLine($"Kayıt Tarihi : {RegistrationDate.ToString("dd/MM/yyyy")}");

        }

    }
}
