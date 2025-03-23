using System;

using F10Y.T0000;


namespace F10Y.T0010
{
    /// <summary>
    /// Attribute indicating an class type is a test fixture implementation type.
    /// Test fixture implementation types must be classes, should be concrete, and and should inherit from a test fixture abstract class,
    /// specifying a the test article type parameter for the fixture.
    /// These test fixture implementation types should not define any TestMethod-marked methods, but instead rely the base abstract test fixture for those.
    /// The test fixture ipmlementation provides a test article instance.
    /// Whether that is a new test article instance for each test is left ambiguous.
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of test fixture types.
    /// </remarks>
    [MarkerAttributeMarker]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class TestFixtureMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a type is *not* a test fixture implementation type.
        /// This is useful for marking types that end up canonical test fixture implementation type code file locations, but are not actually test fixture implementation types.
        /// </summary>
        public bool Is_TestFixture { get; }


        public TestFixtureMarkerAttribute(
            bool is_TestFixture = true)
        {
            this.Is_TestFixture = is_TestFixture;
        }
    }
}
