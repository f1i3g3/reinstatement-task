using TaskLib;

namespace TaskTests
{
    [TestClass]
    public sealed class SorterTests
    {
		private string path = "";
		// TODO: fix path (currently launching from debug)

		// if error, the answer is false
        [TestMethod]
        public void TestNoFile()
        {
			path = Path.Combine(Directory.GetCurrentDirectory(), "Files", "nofile.txt");
			Assert.IsFalse(Checker.CheckForSymmetry(path));
		}

		// empty is symmetrical
		[TestMethod]
		public void TestEmptyList()
		{
			path = Path.Combine(Directory.GetCurrentDirectory(), "Files", "empty.txt");
			Assert.IsTrue(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestOneElemList()
		{
			path = Path.Combine(Directory.GetCurrentDirectory(), "Files", "array1.txt");
			Assert.IsTrue(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestEvenSymmetricalList()
		{
			path = Path.Combine(Directory.GetCurrentDirectory(), "Files", "evensym.txt");
			Assert.IsTrue(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestEvenAsymmetricalList()
		{
			path = Path.Combine(Directory.GetCurrentDirectory(), "Files", "evenasym.txt");
			Assert.IsFalse(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestOddSymmetricalList()
		{
			path = Path.Combine(Directory.GetCurrentDirectory(), "Files", "oddsym.txt");
			Assert.IsTrue(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestOddAsymmetricalList()
		{
			path = Path.Combine(Directory.GetCurrentDirectory(), "Files", "oddasym.txt");
			Assert.IsFalse(Checker.CheckForSymmetry(path));
		}
	}
}
