﻿using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldGetAuthorName()
        {
            Article article = new Article("C# Best Practices", new Author("Nigel", "nigel@gmail.com", "C# Teacher", "www.nigel.com"));

            Assert.AreEqual("Nigel", article.AuthorName);
        }

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Article article = new Article("C# Best Practices", new Author("Nigel", "nigel@gmail.com", "C# Teacher", "www.nigel.com"));
            Assert.AreEqual("item has been checked out", article.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Article article = new Article("C# Best Practices", new Author("Nigel", "nigel@gmail.com", "C# Teacher", "www.nigel.com"));
            article.checkOut();

            Assert.AreEqual("item is currently on loan", article.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Article article = new Article("C# Best Practices", new Author("Nigel", "nigel@gmail.com", "C# Teacher", "www.nigel.com"));
            article.checkOut();

            Assert.AreEqual("item has been checked in", article.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Article article = new Article("C# Best Practices", new Author("Nigel", "nigel@gmail.com", "C# Teacher", "www.nigel.com"));

            Assert.AreEqual("item is not currently on loan", article.checkIn());
        }
    }
}