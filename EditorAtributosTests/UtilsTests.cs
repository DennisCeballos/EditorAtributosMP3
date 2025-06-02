using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtributosUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtributosUI.Tests
{
    [TestClass()]
    public class UtilsTests
    {
        [TestMethod()]
        public void RevisarDireccionPathValidaTest()
        {

            Assert.AreEqual(true, Utils.RevisarDireccionPathValida("C:\\Users\\daceb\\Music\\4K YouTube to MP3"));
            Assert.AreEqual(true, Utils.RevisarDireccionPathValida("C:\\Users\\daceb\\Music"));
            Assert.AreEqual(true, Utils.RevisarDireccionPathValida("C:\\"));
            Assert.AreEqual(true, Utils.RevisarDireccionPathValida("D:\\Musica chevere"));

            Assert.AreEqual(true, Utils.RevisarDireccionPathValida("C:/Users/daceb/Music/4K YouTube to MP3"));
            Assert.AreEqual(true, Utils.RevisarDireccionPathValida("C:/Users/daceb/Music"));
            Assert.AreEqual(true, Utils.RevisarDireccionPathValida("C:/"));
            Assert.AreEqual(true, Utils.RevisarDireccionPathValida("D:/Musica chevere"));

            Assert.AreEqual(false, Utils.RevisarDireccionPathValida("D"));
            Assert.AreEqual(false, Utils.RevisarDireccionPathValida(""));
            Assert.AreEqual(false, Utils.RevisarDireccionPathValida(" "));
            Assert.AreEqual(false, Utils.RevisarDireccionPathValida("/hola"));

        }
    }
}