using Sakura.Status;

namespace Sakura.Core;

public interface IUnit
{
    Stats Stats { get; }
    Identity Identity { get; set; }
    Appearance Appearance { get; }
}