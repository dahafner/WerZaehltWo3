﻿namespace BCA.WerZaehltWo3.Tests.Unit
{
    using System;
    using System.Xml;
    using BCA.WerZaehltWo3.ObjectModel;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class A_0100_PlayerTests
    {
        public void A_Equals_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = InitializedObjects.CreateNewPlayer();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void A_Equals_Functional_01()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = new Player();

            var actual = object1.Equals(object2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void B_Clear_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = new Player();
            object1.Clear();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void C_GetHashCode_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = InitializedObjects.CreateNewPlayer();

            var hash1 = object1.GetHashCode();
            var hash2 = object2.GetHashCode();
            Assert.AreEqual(hash1, hash2);
        }

        [TestMethod]
        public void C_GetHashCode_Functional_01()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = InitializedObjects.CreateNewPlayer2();

            var hash1 = object1.GetHashCode();
            var hash2 = object2.GetHashCode();
            Assert.AreNotEqual(hash1, hash2);
        }

        [TestMethod]
        public void D_Clone_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = object1.Clone();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void E_SaveLoad_ArgumentNull_00()
        {
            var object1 = new Player();
            object1.Load(null);
        }

        [TestMethod]
        public void E_SaveLoad_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = new Player();

            var xml = object1.Save();
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            object2.Load(doc.SelectSingleNode("Player"));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void E_SaveLoad_Functional_01()
        {
            var object1 = new Player();
            var object2 = new Player();

            var xml = object1.Save();
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            object2.Load(doc.SelectSingleNode("Player"));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }
    }
}