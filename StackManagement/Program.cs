using System;

namespace StackManagement
{
    class Program
    {
        public static object StockPortfolio { get; private set; }
        public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {
           
          
                FetchJson fetchJson = new FetchJson();
                Stock data = fetchJson.Read("F:/JSON/Stock.json");

                Console.WriteLine(JsonConvert.SerializeObject(data));

                Console.WriteLine("------------------------STOCK REPORT--------------------------");
                for (int i = 0; i < data.Stock1.Count; i++)
                {
                    Console.WriteLine("<-----------Details of Stock1-------------->");
                    Console.WriteLine("Share Name = " + data.Stock1[i].name);
                    Console.WriteLine("Share Price = " + data.Stock1[i].SharePrice);
                    Console.WriteLine("No Of Shares = " + data.Stock1[i].NoOfShares);
                    double Total = StockPortfolio.StockValue(data.Stock1[i].SharePrice, data.Stock1[i].NoOfShares);
                    Console.WriteLine("Value of Stock1 = " + Total);
                }

                Console.WriteLine("<-----------Details of Stock2-------------->");
                for (int i = 0; i < data.Stock1.Count; i++)
                {
                    Console.WriteLine("Share Name = " + data.Stock2[i].name);
                    Console.WriteLine("Share Price = " + data.Stock2[i].SharePrice);
                    Console.WriteLine("No Of Shares = " + data.Stock3[i].NoOfShares);
                    double Total = StockPortfolio.StockValue(data.Stock2[i].SharePrice, data.Stock2[i].NoOfShares);
                    Console.WriteLine("Value of Stock2 = " + Total);

                }
                Console.WriteLine("<-----------Details of Stock3-------------->");
                for (int i = 0; i < data.Stock3.Count; i++)
                {
                    Console.WriteLine("Share Name = " + data.Stock3[i].name);
                    Console.WriteLine("Share Price = " + data.Stock3[i].SharePrice);
                    Console.WriteLine("No Of Shares = " + data.Stock3[i].NoOfShares);
                    double Total = StockPortfolio.StockValue(data.Stock3[i].SharePrice, data.Stock3[i].NoOfShares);
                    Console.WriteLine("Value of Stock3 = " + Total);

                }
            }
        }
    }
s
