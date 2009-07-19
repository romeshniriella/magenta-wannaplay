﻿
namespace NUnit.Framework
{
    public static class Assetions
    {
        public static void AssertIsEqual(this object left, object right)
        {
            Assert.AreEqual(left, right);
        }

        public static void AssertIsEqual<T>(this T left, T right)
        {
            Assert.AreEqual(left, right);
        }

        public static void AssertIsNull(this object left)
        {
            Assert.IsNull(left);
        }

        public static void AssertIsNotNull(this object left)
        {
            Assert.IsNotNull(left);
        }
    }
}
