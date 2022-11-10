namespace Telemnar.Descriptors;

using System;

using Telemnar.Converters;

/// <summary>
/// Contains information needed to parse arguments of this type.
/// </summary>
public record TypeDescriptor
{
    /// <summary>
    /// The type of the converter used for this type.
    /// </summary>
    public required Type Converter { get; init; }

    /// <summary>
    /// Optionally, an instance of the converter used for this type.
    /// </summary>
    /// <remarks>
    /// If this is <see langword="null"/>, a new converter instance will be created every time.
    /// This optionally supports dependency injection.
    /// </remarks>
    public IConverter? ConverterInstance { get; init; }

    /// <summary>
    /// Specifies whether this argument type is an array.
    /// </summary>
    public required Boolean IsArray { get; init; }
}