using RestoredModel.Model;

namespace TestWinForm
{
    public class Tests
    {
        private static DAO dao;
        [SetUp]
        public void Setup()
        {
            dao = new DAO(); ;
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, 1);
            Assert.Pass();
        }

        [Test]
        public void TestFindExpectingInOrder() 
        {
            List<IncomingOrder> a = dao.GetExpectingOrders();
            foreach(IncomingOrder i in a)
            {
                Assert.IsTrue(i.SignedDate != null && i.ReceivedDate == null && i.DeliverDate != null);
            }
        
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