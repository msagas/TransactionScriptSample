using System;
using TransactionScript.Domain;

namespace TransactionScript.Application
{
    public class BidOnAuctionService
    {
        private BidOnAuctionCommand _bidOnAuctionCommand;

        public BidOnAuctionService(BidOnAuctionCommand bidOnAuctionCommand)
        {
            _bidOnAuctionCommand = bidOnAuctionCommand;
        }

        public void Bid(Guid auctionId, Guid memberId, decimal amount, DateTime dateOfBid)
        {
            _bidOnAuctionCommand.Execute();                             
         }                      
    }
}