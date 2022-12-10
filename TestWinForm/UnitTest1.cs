using RestoredModel.Model;

namespace TestWinForm
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, 1);
            Assert.Pass();
        }

        [Test]
        public void TestSearchBatch()
        {
            DAO dao  = new DAO();
            int[] batchIds = { 3,4 };
            foreach (int i in batchIds) 
            {
                SupplementBatch a = dao.FindBatchByID(i);
                Assert.AreEqual(i, a.BatchID);
            }
        }

        [Test]
        public void TestAgentTransaction()
        {

            Assert.Pass();
        }
    }
}