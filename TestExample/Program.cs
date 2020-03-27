using System;

namespace TestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Auctioneer auctioneer = new Auctioneer();

            Bidder bidder1 = new Bidder("Sławek");
            auctioneer.registerBidder(bidder1);

            Bidder bidder2 = new Bidder("Charlie");
            auctioneer.registerBidder(bidder2);

            Bidder bidder3 = new Bidder("Nidhi");
            auctioneer.registerBidder(bidder3);

            bidder1.giveNewPrice(123);
            bidder2.giveNewPrice(158);
            bidder3.giveNewPrice(208);

            auctioneer.displayNewBidderPrice();

            bidder1.giveNewPrice(243);
            bidder2.giveNewPrice(358);
            bidder3.giveNewPrice(458);

            auctioneer.displayNewBidderPrice();
        }
    }
}
