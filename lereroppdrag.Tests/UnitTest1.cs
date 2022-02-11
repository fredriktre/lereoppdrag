using DataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lereroppdrag.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DBLayer layer = new DBLayer();
            int id = layer.GetIdByUsername("admin");
        }
    }
}
