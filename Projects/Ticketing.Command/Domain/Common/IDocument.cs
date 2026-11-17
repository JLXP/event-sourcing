namespace Ticketing.Command.Domain.Common;


public interface IDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    Object Id {get;set;}
}