/*
Copyright(c) 2016 Markus Trenkwalder

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using KrakenApi;

namespace Test
{
    internal class Program
    {
        private const string krakenKey = "";
        private const string krakenSecret = "";

        private static void Main(string[] args)
        {
            Kraken kraken = new Kraken(krakenKey, krakenSecret, 2500);
            var time = kraken.GetServerTime();
            //var assets = kraken.GetAssetInfo();
            //var assets = kraken.GetAssetPairs();
            //var ticker = kraken.GetTicker("XXBTZEUR");
            //var ohlc = kraken.GetOHLC("XXBTZEUR", 1440);
            //var orderbook = kraken.GetOrderBook("XXBTZEUR");
            //var trades = kraken.GetRecentTrades("XXBTZEUR");
            //var spread = kraken.GetRecentSpread("XXBTZEUR");
            //var accountBalance = kraken.GetAccountBalance();
            //var tradeBalance = kraken.GetTradeBalance();
            //var openOrders = kraken.GetOpenOrders();
            //var closedOrders = kraken.GetClosedOrders();
            //var orders = kraken.QueryOrders(new string[] { "x" });
            //var trades = kraken.GetTradesHistory();
            //var openPositions = kraken.GetOpenPositions(new string[] { "x" });
            //var ledgers = kraken.GetLedgers();
            //var volume = kraken.GetTradeVolume(new string[] { "XXBTZEUR", "XXBTZUSD" }, true);

            //var order = new KrakenOrder();
            //order.Pair = "XXBTZEUR";
            //order.Type = "buy";
            //order.OrderType = "market";
            //order.Volume = 0.01m;
            //order.Validate = true;
            //var result = kraken.AddOrder(order);

            //var depositMethods = kraken.GetDepositMethods(asset: "ZEUR");
            //var depositStatus = kraken.GetDepositStatus("ZEUR", "Fidor Bank AG (SEPA)");
        }
    }
}