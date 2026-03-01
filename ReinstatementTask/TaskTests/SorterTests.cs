using TaskLib;

namespace TaskTests
{
    [TestClass]
    public sealed class SorterTests
    {
		private string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..")); // working directory

		// if error, the answer is false
        [TestMethod]
        public void TestNoFile()
        {
			path =  Path.GetFullPath(Path.Combine(path, "Files", "nofile.txt"));
			Assert.IsFalse(Checker.CheckForSymmetry(path));
		}

		// empty is symmetrical
		[TestMethod]
		public void TestEmptyList()
		{
			path = Path.GetFullPath(Path.Combine(path, "Files", "empty.txt"));
			Assert.IsTrue(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestOneElemList()
		{
			path = Path.GetFullPath(Path.Combine(path, "Files", "array1.txt"));
			Assert.IsTrue(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestEvenSymmetricalList()
		{
			path = Path.GetFullPath(Path.Combine(path, "Files", "evensym.txt"));
			Assert.IsTrue(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestEvenAsymmetricalList()
		{
			path = Path.GetFullPath(Path.Combine(path, "Files", "evenasym.txt"));
			Assert.IsFalse(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestOddSymmetricalList()
		{
			path = Path.GetFullPath(Path.Combine(path, "Files", "oddsym.txt"));
			Assert.IsTrue(Checker.CheckForSymmetry(path));
		}

		[TestMethod]
		public void TestOddAsymmetricalList()
		{
			path = Path.GetFullPath(Path.Combine(path, "Files", "oddasym.txt"));
			Assert.IsFalse(Checker.CheckForSymmetry(path));
		}
	}
}
