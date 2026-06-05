using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design;
//using ---; //카페 메뉴 리스트가 있는 클래스 이름 입력

namespace TeamProject
{
    public class OrderManager
    {
        public static List<CafeOrder> TotalOrders = new List<CafeOrder>();
    }

    public class CafeOrder
    {
        private string _sellerName;
        private int _year;
        private int _month;
        private int _day;
        private int _totalPrice;
        private List<OrderItem> _items = new List<OrderItem>();

        public string SellerName { get => _sellerName; set => _sellerName = value; }
        public int Year { get => _year; set => _year = value; }
        public int Month { get => _month; set => _month = value; }
        public int Day { get => _day; set => _day = value; }
        public int TotalPrice => Items.Sum(item => item.UnitPrice * item.Count);
        public List<OrderItem> Items { get => _items; set => _items = value; }

        public CafeOrder(string sellerName, int cafeMenuNumber, int count)
        {
            _sellerName = sellerName;
            _year = DateTime.Now.Year;
            _month = DateTime.Now.Month;
            _day = DateTime.Now.Day;
            _items.Add(new OrderItem(cafeMenuNumber, count));
        }

        public void PrintReceipt()
        {
            Console.WriteLine("==============================");
            Console.WriteLine($"      [ CAFE RECEIPT ]       ");
            Console.WriteLine($" 주문 일시 : {Year}-{Month}-{Day}");
            Console.WriteLine($" 담당 직원 : {SellerName}");
            Console.WriteLine("------------------------------");

            foreach (var item in Items)
            {
                Console.WriteLine($" - {item.ItemName}\t{item.Count}잔\t{item.UnitPrice * item.Count}원");
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($" 결제 총액 : {TotalPrice}원");
            Console.WriteLine("==============================");
        }
    }

    public class OrderItem
    {
        private Menu _userChoice; //나중에 해당 이름으로 바꾸기
        private string _itemName;
        private int _unitPrice;
        private int _count;

        public Menu UserChoice { get => _userChoice; set => _userChoice = value; }
        public string ItemName { get => _itemName; set => _itemName = value; }
        public int UnitPrice { get => _unitPrice; set => _unitPrice = value; }
        public int Count { get => _count; set => _count = value; }

        public OrderItem(int cafeMenuNumber, int count)
        {
            _userChoice = MenuManager.cafeMenuBoard[cafeMenuNumber]; //static 으로 리스트 선언한 거 들고오기
            _itemName = _userChoice.Name;
            _unitPrice = _userChoice.Price;
            _count = count;
        }
    }
}
