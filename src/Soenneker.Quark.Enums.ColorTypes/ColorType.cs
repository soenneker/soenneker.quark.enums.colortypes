using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// Common html theme and color types in enumeration form.
/// </summary>
[EnumValue<string>]
public sealed partial class ColorType
{
    public static readonly ColorType Default = new(null);
    public static readonly ColorType Primary = new("primary");
    public static readonly ColorType Secondary = new("secondary");
    public static readonly ColorType Success = new("success");
    public static readonly ColorType Danger = new("danger");
    public static readonly ColorType Warning = new("warning");
    public static readonly ColorType Info = new("info");
    public static readonly ColorType Light = new("light");
    public static readonly ColorType Dark = new("dark");
    public static readonly ColorType Link = new("link");
    public static readonly ColorType Muted = new("muted");
}
