using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.MessagePatterns;
using SassyMQ.Lib.RabbitMQ;
using SassyMQ.ADVP.Lib.RabbitMQ;
using SassyMQ.Lib.RabbitMQ.Payload;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


using SassyMQ.ADVP.Lib.RMQActors;
namespace SassyMQ.ADVP.Lib
{
    public static class ADVPExtensions
    {
        public static bool IsLexiconTerm<T>(this StandardPayload<T> payload, LexiconTermEnum termKey)
            where T : StandardPayload<T>, new()
        {
            LexiconTerm term = Lexicon.Terms[termKey];
            return (payload.RoutingKey == term.RoutingKey);
        }
    }
}
