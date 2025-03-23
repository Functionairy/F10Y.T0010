using System;

using F10Y.T0000;


namespace F10Y.T0010
{
    /// <summary>
    /// Attribute indicating an class type is a test article type.
    /// Test article types must be an interface, and declare methods that will be tested by a complementary test fixture type.
    /// The test article is an interface so it can be implemented by a functionality instance method-specific or service definition-specific implementations.
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of test article types.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class TestArticleDefinitionMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a type is *not* a test article type.
        /// This is useful for marking types that end up canonical test article type code file locations, but are not actually test article types.
        /// </summary>
        public bool Is_TestArticleDefinition { get; }


        public TestArticleDefinitionMarkerAttribute(
            bool is_TestArticleDefinition = true)
        {
            this.Is_TestArticleDefinition = is_TestArticleDefinition;
        }
    }
}
