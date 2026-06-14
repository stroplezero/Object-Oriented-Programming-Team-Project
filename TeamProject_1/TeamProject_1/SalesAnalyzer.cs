using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace OrderCoffeeSystem
{
    public class SalesAnalyzer
    {
        private List<RestoredOrderInfo> orders = new List<RestoredOrderInfo>();

        public void LoadSales(string path)
        {
            if (!File.Exists(path)) return;

            orders.Clear();
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] data = line.Split(',');

                int orderNo = int.Parse(data[0]);
                DateTime orderTime = DateTime.Parse(data[1]);
                int totalAmount = int.Parse(data[2]);

                RestoredOrderInfo restoredOrder = new RestoredOrderInfo(orderNo, orderTime, totalAmount);
                orders.Add(restoredOrder);
            }
        }

        public string PrintSales(string togetYear)
        {
            if (orders.Count == 0) return "분석할 데이터가 없습니다.\n";

            int year = int.Parse(togetYear);
            var filteredOrders = orders.Where(o => o.OrderTime.Year == year);

            return GenerateSalesReport($"[연도별 분석 - {togetYear}년]", filteredOrders);
        }

        public string PrintSales(string togetYear, string togetMonth)
        {
            if (orders.Count == 0) return "분석할 데이터가 없습니다.\n";

            int year = int.Parse(togetYear);
            int month = int.Parse(togetMonth);
            var filteredOrders = orders.Where(o => o.OrderTime.Year == year && o.OrderTime.Month == month);

            return GenerateSalesReport($"[월별 분석 - {togetYear}년 {togetMonth}월]", filteredOrders);
        }

        public string PrintSales(string togetYear, string togetMonth, string togetDay)
        {
            if (orders.Count == 0) return "분석할 데이터가 없습니다.\n";

            int year = int.Parse(togetYear);
            int month = int.Parse(togetMonth);
            int day = int.Parse(togetDay);
            var filteredOrders = orders.Where(o => o.OrderTime.Year == year && o.OrderTime.Month == month && o.OrderTime.Day == day);

            return GenerateSalesReport($"[일별 분석 - {togetYear}년 {togetMonth}월 {togetDay}일]", filteredOrders); 
        }

        public string PrintExtremes() 
        {
            if (orders.Count == 0) return "분석할 데이터가 없습니다.\n";

            var maxOrder = orders.OrderByDescending(o => o.TotalAmount).First();
            var minOrder = orders.OrderBy(o => o.TotalAmount).First();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[최고 / 최저 매출 분석]");
            sb.AppendLine($"▶ 총 주문 건수: {orders.Count}건");
            sb.AppendLine($"▶ 최고 매출: {maxOrder.TotalAmount}원 (주문번호: {maxOrder.OrderNo}번)");
            sb.AppendLine($"▶ 최저 매출: {minOrder.TotalAmount}원 (주문번호: {minOrder.OrderNo}번)");

            return sb.ToString();
        }

        public string PrintAverageOrderAmount()
        {
            if (orders.Count == 0) return "분석할 데이터가 없습니다.\n";

            double average = orders.Average(o => o.TotalAmount);
            int totalSales = orders.Sum(o => o.TotalAmount);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[고객 객단가 분석]");
            sb.AppendLine($"▶ 총 주문 건수: {orders.Count}건");
            sb.AppendLine($"▶ 누적 총 매출: {totalSales}원");
            sb.AppendLine($"▶ 1회 결제 시 평균 주문 금액: {Math.Round(average)}원");

            return sb.ToString();
        }

        public string PrintSalesByHour()
        {
            if (orders.Count == 0) return "분석할 데이터가 없습니다.\n";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[시간대별 매출 현황]");

            for (int hour = 0; hour < 24; hour++)
            {
                var hourOrders = orders.Where(o => o.OrderTime.Hour == hour);
                int hourTotal = hourOrders.Sum(o => o.TotalAmount);
                int hourCount = hourOrders.Count();

                if (hourCount > 0)
                {

                    sb.AppendLine($"[{hour:D2}시 ~ {hour + 1:D2}시] 주문: {hourCount}건 | 매출: {hourTotal}원");
                }
            }

            return sb.ToString();
        }

        private string GenerateSalesReport(string title, IEnumerable<RestoredOrderInfo> filteredOrders)
        {
            int matchCount = filteredOrders.Count();
            int total = filteredOrders.Sum(o => o.TotalAmount);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{title}");
            sb.AppendLine($"▶ 해당 기간 주문 건수: {matchCount}건");
            sb.AppendLine($"▶ 누적 총 매출 금액: {total}원");

            return sb.ToString();
        }
    }
}
