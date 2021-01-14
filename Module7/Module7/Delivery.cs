using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    abstract class Delivery
    {
        public string Address;

        public virtual void InputAdress()
        {
            
            Console.WriteLine("Введите адрес для доставки: ");
            string deliveryAdress = Console.ReadLine();
        }
    }

    class HomeDelivery : Delivery
    {
        public override void InputAdress()
        {

            Console.WriteLine("Введите свой домашний адрес для доставки: ");
            string deliveryAdress = Console.ReadLine();

            Console.WriteLine("Добавьте комментарий по доставке (удобные часы, день и т.д.: ");
            string Comment = Console.ReadLine();

            
            // использование конструктора класса с параметрами
            Courier courier = new Courier("Дмитрий", "89043337485");
            courier.Message();
        }
    }

    class PointDelivery
    {
        //тут информация о точках выдачи товара
    }

    class PickPointDelivery : Delivery
    {
        private PointDelivery pointDelivery;

        
        // использование композиции классов
        public PickPointDelivery()
        {
            pointDelivery = new PointDelivery();
        }

        public override void InputAdress()
        {

            Console.WriteLine("Просьба выбрать удобный постамат для получения товара: ");
            // тут будет код по реализации выбора из выпадающего списка постаматов и карта
        }
    }

    class ShopDelivery : Delivery
    {

        public override void InputAdress()
        {

            Console.WriteLine("Просьба выбрать удобный магазин для получения товара: ");
            // тут будет код по реализации выбора из выпадающего списка магазинов и карта
        }
    }

    abstract class Product
    {
        public string Description;

        public Product(string description)
        {
            Description = description;

        }
    }   

    class FoodProducts : Product
    {
        // Булевый флаг, сообщающий, не истек ли срок годности продукта
        public bool IsGood;

        public FoodProducts(string description, bool isGood) : base(description)
        {
            IsGood = isGood;
        }
    }

        class ClothesProducts : Product
        {
            // Размер одежды
            public string Name;
            public string Size;
            

            public ClothesProducts(string name, string description, string size) : base(description)
        {
            Name = name;    
            Size = size;

            }
        }

    // Класс для объекта “Коллекция одежды”
    class ClothesCollection
    {
        // Закрытое поле, хранящее товары в виде массива
        private ClothesProducts[] collection;

        // Конструктор с добавлением массива товаров одежды
        public ClothesCollection(ClothesProducts[] collection)
        {
            this.collection = collection;
        }

        // Индексатор по массиву
        public ClothesProducts this[int index]
        {
            get
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }

            private set
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }
    }

    class BeautyProducts : Product
    {
        // Дата изготовления косметики
        public DateTime ProductionDate;

        public BeautyProducts(string description, DateTime productionDate) : base(description)
        {
            ProductionDate = productionDate;
        }
    }

    class Company
    {
        // это внутренняя информация в компании, она не нужна для внешнего мира
        private string BankAccountNumber;
        private int OrderCounter;

        // а это публичные данные
        public string CompanyAdress;
        public string CompanyPhone;


        public Company()
        {
            BankAccountNumber = "172638er3940djj";
            OrderCounter = 0;
            CompanyAdress = "г. Москва, ул. Покровка, д.7";
            CompanyPhone = "+7 495 780-99-99";
        }

        private void GetOrdersCounter()
        {
            // считаем количество заказов
            OrderCounter++;
        }

        public void AboutCompany()
        {
            Console.WriteLine("Адрес нашей компании: {0}, телефон: {1}", CompanyAdress, CompanyPhone);
        }

    }

    public class UserAccount
    {
        private string login;
        private string password;
        private string name;
        private string surname;

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        // свойство с логикой в блоке set
        private string Password
        {
            get
            {
                return password;
            }

            set
            {
                if (password.Length < 5)
                {
                    Console.WriteLine("Длина пароля должна быть не менее 5 символов");
                }
                else
                {
                    password = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        // остальной код
    }

    class Courier
    {
        // Поля класса
        public string name;
        public string phone;

        // Метод класса
        public void Message()
        {
            Console.WriteLine("К Вам выехал курьер {0}, телефон курьера {1}", name, phone);
        }

        // Конструктор с параметрами
        public Courier(string n, string ph)
        {
            name = n;
            phone = ph;
        }
    }

    public class Calculations
    {
        public static double SumWithDelivery(double costOfGoods, double costOfDelivery)
        {
            return costOfDelivery + costOfGoods;
        }
    }

    // методы расширения
    static class StringExtensions
    {
        public static char GetFirstChar(this string source)
        {
            return source[0];
        }

        public static char GetSeveralChar(this string source)
        {
            char initials = default;
            // тут будет реализация метода, который будет выборочно отбирать сокращения имени и фаимилии пользователя для того,
            // чтобы указывать на чеке и тд. 
            return initials;
           
        }
    }

    class BaseDocumentClass<T>
    {
        public T Field;

        // тут код для универсального документа, от которого потом наследуются другие документы: чеки, договора с компанией и тд
    }

    // наследование от обобщения
    class CheckClass<T> : BaseDocumentClass<T>
    {
        public T Property { get; set; }
        
        // использование агрегации классов
        private UserAccount userAccount;
        public CheckClass(UserAccount userAccount)
        {
            this.userAccount = userAccount;
        }

        // тут код, относящийся к описанию чека и его методам

        public void SendingACheck()
        {
            userAccount.Name = "Павел";
            userAccount.Surname = "Михайлов";
            // использование метода расширения
            char inicialsForCheck = userAccount.Surname.GetSeveralChar();

            // дальше код по формированию информации на чеке и отправки чека

            Console.ReadKey();
        }
    }

    class Order<TDelivery> where TDelivery : Delivery 
    {
        // использование обобщений
        public TDelivery Delivery;

        public int Number;

        // использование агрегации классов
        private UserAccount userAccount;
        public Order(UserAccount userAccount)
        {
            this.userAccount = userAccount;
        }

        public void UserIdentification()
        {          
            // Использование свойств
            // Setter
            userAccount.Login = "Zakazik";

            // Getter
            Console.WriteLine("Привет, {0}!", userAccount.Login);

            
            // тут код, проверяющий, зарегистрирован пользователь или нет, если нет, то используем метод регистрации           
            
        }

        public void UserRegistration()
        {
            userAccount.Name = "Павел";
            userAccount.Surname = "Михайлов";
            // использование метода расширения
            char reductionSurname = userAccount.Surname.GetFirstChar();

            Console.WriteLine("Уважаемый {0} {1}., добро пожаловать!", userAccount.Name, reductionSurname);

            Console.ReadKey();
        }

        public void GetCostOfGoods()
        {
            // использование статического метода
            double sum = Calculations.SumWithDelivery(100, 15000);

            Console.WriteLine("Уважаемый покупатель, стоимость товара с доставкой составляет {0} рублей", sum);
        }

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

       // использование обобщенного метода
        public void DisplayProductDescription<TProduct>(TProduct product) where TProduct:Product
        {
            Console.WriteLine(product.Description);
        }

        // в методе используется класс с наследованием обобщений
        public void PurchaseClothes(CheckClass<string> value)
        {
            CheckClass<string> check = value;
            check.Field = "Интернет-покупка одежды";

            //код метода покупки
        }
      

        // ... Другие поля
    }
}
