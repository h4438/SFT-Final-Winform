using RestoredModel.Model;

namespace TestWinForm
{
    public class Tests
    {
        private DAO dao;
        [SetUp]
        public void Setup()
        {
            dao = new DAO();
        }

        [Test]
        public void TestExecSQLFunction()
        {
            int[] data = { 4, 6, 2011, 2022 };
            List<ReportRangeAgentSales_Result> res = dao.GetSalesReport(data);
            foreach(ReportRangeAgentSales_Result a in res)
            {
                Assert.NotNull(a);
                Assert.NotNull(a.Sold);
                Assert.IsNotEmpty(a.Buyer);
                Assert.IsNotEmpty(a.Supplement);
            }
            Assert.LessOrEqual(4, res.Count);
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