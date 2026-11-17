namespace Ticketing.Command.Domain.Common;

public class Document : IDocument
{
    [BsonRepresentation(BsonType.String)]
    public object Id {get;set;}
}