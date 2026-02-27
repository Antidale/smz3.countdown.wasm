using smz3.countdown.wasm.Enums;
using smz3.countdown.wasm.Extenstions;

namespace smz3.countdown.wasm.Attributes;

public class ObjectiveTypeAttribute(ObjectiveType objectiveType) : Attribute
{
    public ObjectiveType Type = objectiveType;
    public override string ToString()
    {
        return Type.GetDescription();
    }
}
