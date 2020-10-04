using Microsoft.VisualStudio.TestTools.UnitTesting;
using config;
using System;

namespace config
{

    [TestClass]
    public class ConfigTests
    {
        [TestMethod]
        public void VisibilityTests()
        {
            #region Setup
            // TODO: Add setup code later
            #endregion

            #region Visibility Tests
            Assert.IsTrue(MainPage.hastobetrue);
            Assert.IsTrue(MainPage.hastobefalse);
            // TODO: Add visibility tests
            /**
            Assert.AreEqual(Visibility.Collapsed, MainPage.Stop.Visibility);
            Assert.AreEqual(Visibility.Visible, MainPage.Start.Visibility);
            **/
            #endregion
        }
    }
}
