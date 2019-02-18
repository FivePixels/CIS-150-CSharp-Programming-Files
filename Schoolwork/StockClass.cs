using System;
class Stock
{
    public string symbol;
    public string stockName;
    public double previousClosingPrice;
    public double currentPrice;
    public Stock()
    {
        // nothing here! (the empty constructor)
    }
    public Stock(string stocksymbol, string desc)
    {
        symbol = stocksymbol;
        stockName = desc;
    }
    public void setPrice(double current, double closing)
    {
        currentPrice = current;
        previousClosingPrice = closing;
        return;
    }
    public double getChangePercent()
    {
        return (previousClosingPrice - currentPrice) / currentPrice * 100;
    }
}