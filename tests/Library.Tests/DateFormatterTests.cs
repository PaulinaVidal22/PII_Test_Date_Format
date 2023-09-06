using NUnit.Framework;
using TestDateFormat;

namespace Library.Tests;

public class DateFormatterTestsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void IsDateInACorrectFormat()
    {
        string dateExpected = "2004-09-22";
        string input = "22/09/2004";
        Assert.AreEqual(dateExpected,DateFormatter.ChangeFormat(input));
    }

    [Test]
    public void IsDateInAnIncorrectFormat()
    {
        string dateExpected = "Error : Invalid Format";
        string input = "2004-09-22";
        Assert.AreEqual(dateExpected, DateFormatter.ChangeFormat(input));
    }

    [Test]
    public void IsDateEmpty()
    {
        string dateExpected = "Error : Empty string";
        string input = "";
        Assert.AreEqual(dateExpected, DateFormatter.ChangeFormat(input));

    }
}