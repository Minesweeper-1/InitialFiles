﻿namespace Minesweeper.Logic.Tests.Contents
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Logic.Contents;
    using Logic.Common;

    /// <summary>
    /// Defines unit tests for the EmptyContent class in Minesweeper.Logic.Contents
    /// </summary>
    [TestClass]
    public class EmptyContentTests
    {
        [TestMethod]
        public void ConstructorSetsCorrectEmptyContentProperties()
        {
            var empty = new EmptyContent();

            Assert.AreEqual(ContentType.Empty, empty.ContentType);
            Assert.AreEqual(default(int), empty.Value);
        }
    }
}
