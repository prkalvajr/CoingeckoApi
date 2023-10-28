namespace _angularJS.Models
{
    public class CoinModel
    {
        public string Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Current_price { get; set; }
        public long Market_cap { get; set; }
        public int Market_cap_rank { get; set; }
        public long Total_volume  { get; set; }
        public decimal High_24h { get; set; }
        public decimal Low_24h { get; set; }
        public decimal Proce_change_24h { get; set; }
        public decimal Circulating_supply { get; set; }
        public decimal? Total_supply { get; set; }
        public decimal Ath { get; set; }
        public decimal Ath_change_percentage { get; set; }
        public DateTime Ath_date { get; set; }

        /*         
            "fully_diluted_valuation":214075417762,
            "price_change_percentage_24h":-0.62374,
            "market_cap_change_24h":-1976454366.0385742,
            "market_cap_change_percentage_24h":-0.91481,
            "max_supply":null,
            "atl":0.432979,
            "atl_change_percentage":411003.1,
            "atl_date":"2015-10-20T00:00:00.000Z",
            "roi":{
               "times":69.22925197588866,
               "currency":"btc",
               "percentage":6922.925197588866
            },
            "last_updated":"2023-10-28T01:07:06.542Z"
       */
    }
}
