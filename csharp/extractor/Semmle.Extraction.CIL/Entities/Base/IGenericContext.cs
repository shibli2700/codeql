using System.Collections.Generic;

namespace Semmle.Extraction.CIL
{
    /// <summary>
    /// When we decode a type/method signature, we need access to
    /// generic parameters.
    /// </summary>
    public interface IGenericContext
    {
        Context Cx { get; }

        /// <summary>
        /// The list of generic type parameters/arguments, including type parameters/arguments of
        /// containing types.
        /// </summary>
        IEnumerable<Entities.Type> TypeParameters { get; }

        /// <summary>
        /// The list of generic method parameters/arguments.
        /// </summary>
        IEnumerable<Entities.Type> MethodParameters { get; }
    }
}
