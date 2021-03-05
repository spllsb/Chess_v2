using System;

namespace Chess.Core.Domain
{
    public class Tournament
    {
        public Guid Id { get; protected set;}
        public string Name { get; protected set; }
        public Tournament()
        {
            
        }
    }
}
