using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;
    [SetUp]
    public void SetUp()
    {
        _article = new Article();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articles = new string[]
        { 
            "Article Content Author",
            "Article2 Content2 Author2",
            "Article3 Content3 Author3 "
        };

        // Act
        Article result = _article.AddArticles(articles);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        string[] articles = new string[]
        {
            "Zebra Eating Ann",
            "Elephant Walking John",
            "Monkey Singing Peter"
        };
        string printCriteria = "title";

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Elephant - Walking: John");
        sb.AppendLine("Monkey - Singing: Peter");
        sb.AppendLine("Zebra - Eating: Ann");

        Article article = _article.AddArticles(articles);

        string expected = sb.ToString().TrimEnd();

        // Act
        string result = _article.GetArticleList(article, printCriteria);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByContent()
    {
        // Arrange
        string[] articles = new string[]
        {
            "Zebra Eating Ann",
            "Elephant Walking John",
            "Monkey Singing Peter"
        };
        string printCriteria = "content";

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Zebra - Eating: Ann");
        sb.AppendLine("Monkey - Singing: Peter");
        sb.AppendLine("Elephant - Walking: John");

        Article article = _article.AddArticles(articles);

        string expected = sb.ToString().TrimEnd();

        // Act
        string result = _article.GetArticleList(article, printCriteria);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByAuthor()
    {
        // Arrange
        string[] articles = new string[]
        {
            "Zebra Eating Ann",
            "Elephant Walking John",
            "Monkey Singing Peter"
        };
        string printCriteria = "author";

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Zebra - Eating: Ann");
        sb.AppendLine("Elephant - Walking: John");
        sb.AppendLine("Monkey - Singing: Peter");

        Article article = _article.AddArticles(articles);

        string expected = sb.ToString().TrimEnd();

        // Act
        string result = _article.GetArticleList(article, printCriteria);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        string[] articles = new string[]
        {
            "Zebra Eating Ann",
            "Elephant Walking John",
            "Monkey Singing Peter"
        };
        string printCriteria = "invalid print criteria";

        Article article = _article.AddArticles(articles);

        // Act
        string result = _article.GetArticleList(article, printCriteria);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
