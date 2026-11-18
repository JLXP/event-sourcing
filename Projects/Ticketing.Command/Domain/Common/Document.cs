using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ticketing.Command.Domain.Common;

public class Document : IDocument
{
    [BsonRepresentation(BsonType.String)]
    public ObjectId Id {get;set;}
}