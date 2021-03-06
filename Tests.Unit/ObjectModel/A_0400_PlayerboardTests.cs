﻿using BCA.WerZaehltWo3.Shared.Helpers;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BCA.WerZaehltWo3.Tests.Unit.ObjectModel
{
    [TestClass]
    public class A_0400_PlayerboardTests
    {
        [TestMethod]
        public void A_Equals_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerboard();
            var object2 = InitializedObjects.CreateNewPlayerboard();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void A_Equals_Functional_01()
        {
            var object1 = InitializedObjects.CreateNewPlayerboard();
            var object2 = new Playerboard();

            var actual = object1.Equals(object2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void B_Clear_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerboard();
            var object2 = new Playerboard();
            object1.Clear();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }       

        [TestMethod]
        public void E_SaveLoad_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerboard();

            var json = JsonHelper.Save(object1);
            var object2 = (Playerboard)JsonHelper.Load(json, typeof(Playerboard));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void E_SaveLoad_Functional_01()
        {
            var object1 = new Playerboard();

            var json = JsonHelper.Save(object1);
            var object2 = (Playerboard)JsonHelper.Load(json, typeof(Playerboard));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }
    }
}