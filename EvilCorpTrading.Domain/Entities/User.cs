using EvilCorpTrading.Domain.ValueObjects;

namespace EvilCorpTrading.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public AdAccount AdAccount { get; set; }
    }
}
