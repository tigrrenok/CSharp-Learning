using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OnlineStore
{

    public static class Program
    {
        public static void Main()
        {
            var store = new Store();
            var IsAdminMode = false;
          

            while (true)
            {
                if (IsAdminMode) ShowAdminMenu();
                else ShowMenu();
                string data = Console.ReadLine();
                switch (data)
                {
                    case "1": store.ShowCatalog(); break;
                    case "2": store.AddProductToBasket(); break;
                    case "3": store.ShowBasket(); break;
                    case "4": store.DeleteFromBasket(); break;
                    case "5": Console.Clear();  break;
                    case "6": store.ClearBasket(); break;
                    case "7":
                        { 
                            bool res = store.BuyProductsFromBasket();
                            if (res) return;
                            break; }

                    default: Console.WriteLine("Непонятная команда"); break;
                }
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("                    ------------------------------------------");
            Console.WriteLine("                    Выберите действие, которое хотите соверишить:");
            Console.WriteLine("                    1   Посмотреть каталог");
            Console.WriteLine("                    2   Добавить товар в коризину");
            Console.WriteLine("                    3   Посмотреть корзину");
            Console.WriteLine("                    4   Удалить товар из корзины");
            Console.WriteLine("                    5   Очистить историю");
            Console.WriteLine("                    6   Удалить все из корзины");
            Console.WriteLine("                    7   Купить товары в корзине");
            Console.WriteLine("                    8   Войти в режиме администратора");
        }

        private static void ShowAdminMenu()
        {
            Console.WriteLine("                    ------------------------------------------");
            Console.WriteLine("                    РЕЖИМ АДМИНИСТРАТОРА");
            Console.WriteLine("                    Выберите действие, которое хотите соверишить:");
            Console.WriteLine("                    1   Посмотреть каталог");
            Console.WriteLine("                    2   Добавить товар в каталог");
            Console.WriteLine("                    4   Удалить товар из каталога");
            Console.WriteLine("                    5   Изменить Количество товара");
            Console.WriteLine("                    6   Изменить цену товара");
            Console.WriteLine("                    7   Выйти из режима администратора");
        }

    }
}

  