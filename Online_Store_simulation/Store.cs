namespace OnlineStore
{
    public class Store
    {
        public Dictionary<Product, int> Products = new Dictionary<Product, int>()
        {
            { new Product("Титратор", 1000), 2 },
            { new Product("рН-метр", 100), 4 },
            { new Product("рН-Электрод", 50), 3 },
            { new Product("Бюретка", 500), 2 },
            { new Product("Кабель", 10), 2 },
            { new Product("Pастворы", 50), 5 }
        };

        public Dictionary<Product, int> Basket = new Dictionary<Product, int>();

        private decimal totalCost = 0M;
        public Store() { }

        public void ShowCatalog()
        {
            bool flag = false; 
            Console.WriteLine("Магазин Лабораторного оборудования ЛабСтор");
            Console.WriteLine("------------------------------------------");
            foreach (Product p in Products.Keys)
            {
                if (Products[p] > 0)
                {
                    flag = true;
                    Console.Write("{0, -15} ||  ", p.Name);
                    Console.WriteLine($"{p.Price:0.00} $");
                }
                else
                {
                    Console.Write("{0, -15} ||  ", p.Name);
                    Console.WriteLine($"Товар закончился");
                }

            }
            if (!flag) Console.WriteLine("Товар закончился, ждем вас завтра!");
            Console.WriteLine("------------------------------------------");
        }

        public void AddProductToBasket()
        {
            Console.WriteLine("Введите название товара");
            var data = Console.ReadLine().ToLower();
            Product product;

            bool IsInStore = false;
            foreach (var pair in Products)
            {
                if (pair.Key.Name.ToLower() == data && Products[pair.Key] > 0)
                {
                    IsInStore = true;
                    product = pair.Key;
                    if (Basket.Keys.Contains(product))
                    {
                        Basket[product]++;
                    }
                    else
                    {
                        Basket[product] = 1;
                    }
                    Products[product]--;
                    Console.WriteLine($"Товар {product.Name} успешно добавлен в корзину");
                    totalCost += product.Price;
                }
            }
            if (!IsInStore) Console.WriteLine("Такого товара в магазине нет");

        }

        public void ShowBasket()
        {
            bool IsNotEmptyl = false;
            Console.WriteLine("Корзина");
            Console.WriteLine("------------------------------------------");
            foreach (Product p in Basket.Keys)
            {
                {
                    IsNotEmptyl = true;
                    Console.Write("{0, -15} ||  ", p.Name);
                    Console.Write($"{p.Price:0.00} $ ||  ");
                    Console.WriteLine($"{Basket[p]} штук");
                }   

            }
            if (IsNotEmptyl) { Console.WriteLine($"Общая стоимость           {totalCost:0.00} $"); }
            if (!IsNotEmptyl) Console.WriteLine("Корзина пока пустая!");
            Console.WriteLine("------------------------------------------");
        }

        public void DeleteFromBasket()
        {
            Console.WriteLine("Введите название товара, который вы хотите удалить");
            var data = Console.ReadLine().ToLower();
            bool IsInBasket = false;
            Product product;
            foreach (var pair in Basket)
            {
                if (pair.Key.Name.ToLower() == data)
                {
                    product = pair.Key;
                    IsInBasket = true;
                    Basket[product]--;
                    Products[product]++;
                    totalCost -= product.Price;
                    Console.WriteLine($"Количество товара {product.Name} уменьшено на 1"); 
                    if (Basket[product] == 0) 
                    {
                        Basket.Remove(product);
                        Console.WriteLine($"Товар {product.Name} удален из корзины");
                    }

                }

            }
            if (!IsInBasket) Console.WriteLine("Такого товара в корзине нет");
        }

        public void ClearBasket()
        {
            foreach (var pair in Basket)
            {
                Products[pair.Key] += pair.Value;
            }
            Basket.Clear();
            totalCost = 0;
        }


        public bool BuyProductsFromBasket()
        {
            if (Basket.Count == 0)
            {
                Console.WriteLine("Корзина пока пустая!");
                return false;
            }
            else
            {
                Console.WriteLine($"Общая стоимость товоров в корзине:");
                ShowBasket();
                Console.WriteLine("Для подтверждения оплаты нажмите 1");
                var PaymentApproval = Console.ReadLine();
                if (PaymentApproval == "1")
                {
                    Console.WriteLine("Поздравляем! Оплата прошла успешно!");
                    Console.WriteLine("Ждем вас снова!");
                    return true;
                }
                else return false;
            }
        }

    }
}

  