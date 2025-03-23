using System;

using F10Y.T0000;


namespace F10Y.T0010
{
    /// <summary>
    /// Attribute indicating an class type is a test fixture type.
    /// Test fixture types must be classes, should be abstract, should be generic in a TTestArticle type, and should inherit from R5T.T0242.TestFixtureBase&lt;TTestArticle&gt;.
    /// These test fixture types define TestMethod-marked methods that test calls to methods of the TTestArticle type.
    /// The test fixture class should restrict the TTestArticle generic type using an ITestArticle interface that defines methods that will be implemented calls to
    /// functionality instance methods in a functionality instance method specific test article implementation,
    /// or calls to a service definition in a service definition specific test article implementation.
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of test fixture types.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class TestFixtureDefinitionMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a type is *not* a test fixture type.
        /// This is useful for marking types that end up canonical test fixture type code file locations, but are not actually test fixture types.
        /// </summary>
        public bool Is_TestFixture { get; }


        public TestFixtureDefinitionMarkerAttribute(
            bool is_TestFixture = true)
        {
            this.Is_TestFixture = is_TestFixture;
        }
    }
}
