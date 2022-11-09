namespace Telemnar.Descriptors;

using System;

/// <summary>
/// Represents metadata about a command argument.
/// </summary>
public sealed record ArgumentDescriptor
{
    /// <summary>
    /// The single-character short-form name of this argument.
    /// </summary>
    /// <remarks>
    /// This may conflict with other short-form names <i>if</i> and only if a <seealso cref="Priority"/> is
    /// defined on all conflicting arguments and does not exhibit any conflicts.
    /// </remarks>
    public Char? ShortFormName { get; init; }

    /// <summary>
    /// The priority given to this argument, should there be multiple arguments with the same
    /// <seealso cref="ShortFormName"/> in the present list.
    /// </summary>
    /// <remarks>
    /// If a conflict is present in the given argument list, the priority will be used to resolve it.
    /// The parser will prefer populating in the following order: <br/>
    /// - Firstly, all required arguments, ordered by descending priority. If not all required arguments
    /// could be populated, the parser will fail. <br/>
    /// - Secondly, all optional arguments, ordered again by descending priority. <br/> <br/>
    /// This means that the order of priorities does <i>not</i> guarantee order of parsing alone.
    /// </remarks>
    public Int16? Priority { get; init; }

    /// <summary>
    /// Specifies whether this argument is required to be populated. Defaults to <see langword="false"/>.
    /// </summary>
    /// <remarks>
    /// This value can affect parsing order if multiple conflicting <seealso cref="ShortFormName"/> fields
    /// are present in the current list. For more information, refer to <seealso cref="Priority"/>.
    /// </remarks>
    public Boolean Required { get; init; } = false;

    /// <summary>
    /// The long-form name of this argument. There must not be conflicting long-form names in any argument list.
    /// </summary>
    public required String LongFormName { get; init; }

    // todo: expected argument type & related properties
}
