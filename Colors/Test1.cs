namespace Colors
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = ".NET 10";
            Assert.AreEqual("HELLO!", actual);
        }
    }
}
