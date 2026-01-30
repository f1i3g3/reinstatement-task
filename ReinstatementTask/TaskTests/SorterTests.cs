using TaskLib;

namespace TaskTests
{
    [TestClass]
    public sealed class SorterTests
    {
		private string path = "";

		// if error, the answer is false
        [TestMethod]
        public void TestNoFile()
        {
			path = Path.Combine("Files", "nofile.txt");
			Assert.IsFalse(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestEmptyList()
		{
			path = Path.Combine("Files", "empty.txt");
			Assert.IsTrue(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestOneElemList()
		{
			path = Path.Combine("Files", "array1.txt");
			Assert.IsTrue(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestEvenSymmetricalList()
		{
			path = Path.Combine("Files", "evensym.txt");
			Assert.IsTrue(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestEvenAsymmetricalList()
		{
			path = Path.Combine("Files", "evenasym.txt");
			Assert.IsFalse(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestOddSymmetricalList()
		{
			path = Path.Combine("Files", "oddsym.txt");
			Assert.IsTrue(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestOddAsymmetricalList()
		{
			path = Path.Combine("Files", "oddasym.txt");
			Assert.IsFalse(Checker.CheckForSymmetry(path));
		}
	}
}
