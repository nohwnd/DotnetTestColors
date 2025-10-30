namespace Colors
{
    [TestClass]
    public sealed class Test2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = "I am new code.";
            Assert.AreEqual("And I fail in PR build!", actual);
        }
    }
}
