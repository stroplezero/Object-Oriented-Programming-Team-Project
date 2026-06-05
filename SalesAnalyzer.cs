using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TeamProject
{
    internal class SalesAnalyzer
    {
        public void PrintSales(List<CafeOrder> orders, int togetYear)
        {
            var filteredOrders = orders.Where(o => o.Year == togetYear);
            int total = 0;
            foreach (var o in filteredOrders)
            {
                total += o.TotalPrice;
            }
            Console.WriteLine($"[연도별 조회] {togetYear}년도 총 매출: {total}원\n");
        }

        public void PrintSales(List<CafeOrder> orders, int togetYear, int togetMonth)
        {
            var filteredOrders = orders.Where(o => o.Year == togetYear && o.Month == togetMonth);
            int total = 0;
            foreach (var o in filteredOrders)
            {
                total += o.TotalPrice;
            }
            Console.WriteLine($"[월별 조회] {togetYear}년도 {togetMonth}월 총 매출: {total}원\n");
        }

        public void PrintSales(List<CafeOrder> orders, int togetYear, int togetMonth, int togetDay)
        {
            var filteredOrders = orders.Where(o => o.Year == togetYear && o.Month == togetMonth && o.Day == togetDay);
            int total = 0;
            foreach (var o in filteredOrders)
            {
                total += o.TotalPrice;
            }
            Console.WriteLine($"[일별 조회] {togetYear}년도 {togetMonth}월 {togetDay}일 총 매출: {total}원\n");
        }

        public void PrintMenuSales(List<CafeOrder> orders, string menuName)
        {
            int totalSales = 0;

            foreach (var order in orders)
            {
                foreach (var item in order.Items)
                {
                    if (item.ItemName == menuName)
                    {
                        totalSales += item.UnitPrice * item.Count;
                    }
                }
            }

            Console.WriteLine($"[{menuName}] 메뉴의 총 매출: {totalSales}원\n");
        }

        public void PrintSellerSales(List<CafeOrder> orders, string sellerName)
        {
            int totalSales = 0;

            foreach (var order in orders)
            {
                if (order.SellerName == sellerName)
                {
                    foreach (var item in order.Items)
                    {
                        totalSales += item.UnitPrice * item.Count;
                    }
                }
              
            }

            Console.WriteLine($"[{sellerName}] 직원의 총 판매액: {totalSales}원\n");
        }
    }
}
