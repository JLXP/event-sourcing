using Common.Core.Messages;

namespace Common.Core.Events;

public abstract class BaseEvent:Message
{
    protected BaseEvent(string type)
    {
        Type = type;
    }

    //un evento es un mensaje
    public int Version { get; set; }

    public string Type { get; set; }

    
}