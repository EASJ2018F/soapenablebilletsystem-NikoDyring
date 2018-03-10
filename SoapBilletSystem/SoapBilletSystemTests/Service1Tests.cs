using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoapBilletSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapBilletSystem.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void BilTypeSOAPTest()
        {
            // Arrange
            Service1 s1 = new Service1();
            // Act
            string bilType = s1.BilTypeSOAP(s1.CreateBilSOAP("AA12345"));

            // Assert
            Assert.AreEqual("Bil", bilType);
        }

        [TestMethod()]
        public void MCTypeSOAPTest()
        {
            // Arrange
            Service1 s1 = new Service1();
            // Act
            string mcType = s1.MCTypeSOAP(s1.CreateMCSOAP("AA12345"));

            // Assert
            Assert.AreEqual("MC", mcType);
        }

        [TestMethod()]
        public void BilPrisSOAPTest()
        {
            // Arrange
            Service1 s1 = new Service1();
            // Act
            int bilPris = s1.BilPrisSOAP(s1.CreateBilSOAP("AA12345"));

            // Assert
            Assert.AreEqual(240, bilPris);
        }

        [TestMethod()]
        public void MCPrisSOAPTest()
        {
            // Arrange
            Service1 s1 = new Service1();
            // Act
            int mcPris = s1.MCPrisSOAP(s1.CreateMCSOAP("AA12345"));

            // Assert
            Assert.AreEqual(125, mcPris);
        }

        [TestMethod()]
        public void ØresundBilPrisSOAPTest()
        {
            // Arrange
            Service1 s1 = new Service1();
            // Act
            int bilPris = s1.ØresundBilPrisSOAP(s1.CreateBilOSOAP("AA12345"));

            // Assert
            Assert.AreEqual(410, bilPris);
        }

        [TestMethod()]
        public void ØresundMCPrisSOAPTest()
        {
            // Arrange
            Service1 s1 = new Service1();
            // Act
            int mcPris = s1.ØresundMCPrisSOAP(s1.CreateMCOSOAP("AA12345"));

            // Assert
            Assert.AreEqual(210, mcPris);
        }

        [TestMethod()]
        public void CreateBilSOAPTest()
        {
            // Arrange
            Service1 s1 = new Service1();
            // Act
            var b1 = s1.CreateBilSOAP("AA12345");

            // Assert
            Assert.AreEqual("AA12345", b1.NummerPlade);
        }

        [TestMethod()]
        public void CreateBilOSOAPTest()
        {
            // Arrange
            Service1 s1 = new Service1();
            // Act
            var b1 = s1.CreateBilOSOAP("AX12345");

            // Assert
            Assert.AreEqual("AX12345", b1.NummerPlade);
        }

        [TestMethod()]
        public void CreateMCSOAPTest()
        {
            // Arrange
            Service1 s1 = new Service1();
            // Act
            var b1 = s1.CreateMCSOAP("ZZ12345");

            // Assert
            Assert.AreEqual("ZZ12345", b1.NummerPlade);
        }

        [TestMethod()]
        public void CreateMCOSOAPTest()
        {
            // Arrange
            Service1 s1 = new Service1();
            // Act
            var b1 = s1.CreateMCOSOAP("XX12345");

            // Assert
            Assert.AreEqual("XX12345", b1.NummerPlade);
        }
    }
}