using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
using StockData.Worker.Context;
using StockData.Worker.Models;

namespace StockData.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        public AppDbContext db;
        
        Company company ;
        StockPrice stockPrice;
        string status;
        public List<StockPrice> list;


        public Worker(ILogger<Worker> logger)
        {
            list = new List<StockPrice>();
           
            
            _logger = logger;

            var connectionstring = "Server=.\\SQLEXPRESS;Database=StockDb1;Trusted_Connection=True;MultipleActiveResultSets=true";

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);

            db= new AppDbContext(optionsBuilder.Options);   
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            while (!stoppingToken.IsCancellationRequested)
            {
                var html1 = @"https://www.dse.com.bd/latest_share_price_scroll_l.php";

                HtmlWeb web1 = new HtmlWeb();

                var htmlDoc1 = web1.Load(html1);

                var node1 = htmlDoc1.DocumentNode.SelectSingleNode("//span[@class='green']");

                status = node1.InnerText;

                // _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                var html = @"https://www.dse.com.bd/latest_share_price_scroll_l.php";

                HtmlWeb web = new HtmlWeb();

                var htmlDoc = web.Load(html);

                var node = htmlDoc.DocumentNode.SelectSingleNode("//table[@class='table table-bordered background-white shares-table fixedHeader']");

                //Console.WriteLine(node.OuterHtml);

                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(node.OuterHtml);
                foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table"))
                {
                    foreach (HtmlNode row in table.SelectNodes("tr"))
                    {
                        int cellno = 1;
                        company = new Company();
                        stockPrice = new StockPrice();

                        foreach (HtmlNode cell in row.SelectNodes("th|td"))
                        {
                            if (cellno == 2)
                            {
                                string str = cell.InnerText.Trim();
                                company.TradeCode = str;
                                stockPrice.CompanyId = company;
                            }
                            if (cellno == 3)
                            {
                                stockPrice.LastTradingPrice = cell.InnerText.Trim();
                            }
                            if (cellno == 4)
                            {
                                stockPrice.High = cell.InnerText.Trim();
                            }
                            if (cellno == 5)
                            {
                                stockPrice.Low = cell.InnerText.Trim();
                            }
                            if (cellno == 6)
                            {
                                stockPrice.ClosePrice = cell.InnerText.Trim();
                            }
                            if (cellno == 7)
                            {
                                stockPrice.YesterdayClosePrice = cell.InnerText.Trim();
                            }
                            if (cellno == 8)
                            {
                                stockPrice.Change = cell.InnerText.Trim();
                            }
                            if (cellno == 9)
                            {
                                stockPrice.Trade = cell.InnerText.Trim();
                            }

                            if (cellno == 10)
                            {
                                stockPrice.Value = cell.InnerText.Trim();
                            }

                            if (cellno == 11)
                            {
                                stockPrice.Volume = cell.InnerText.Trim();
                            }

                            cellno++;
                        }

                        list.Add(stockPrice);

                    }
                }

                foreach (var item in list)
                {
                    db.stocks.AddAsync(item);
                }

                if(status != "Closed")
                {
                    db.SaveChangesAsync();
                }

                list.Clear();   

                await Task.Delay(60000, stoppingToken);
            }
        }
    }
}