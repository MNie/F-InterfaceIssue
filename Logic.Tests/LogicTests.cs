using Xunit;

namespace Logic.Tests
{
    using Shouldly;

    public class LogicTests
    {
        //Returns CS1061 The element "SomeClass" does not contain definition of Some, and an extension "Some" which accepts first argument SomeClass was not found.
        [Fact]
        public void Some_Returnsdd()
        {
            var sut = new SomeClass();
            var result = sut.Some("heh");
            result.ShouldBe("dd");
        }
        
        //compiles
        [Fact]
        public void Some_Returnsdd2()
        {
            IInterface sut = new SomeClass();
            var result = sut.Some("heh");
            result.ShouldBe("dd");
        }
    }
}