using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //Arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.2);
            book.AddGrade(82.3);
            book.AddGrade(77.7);
            book.AddGrade(66.1);

            //Act
            var result = book.GetStats();

            //Assert
            Assert.Equal(78.8, result.Average, 1);
            Assert.Equal(89.2, result.High, 1);
            Assert.Equal(66.1, result.Low, 1);
            Assert.Equal('C',result.Letter);
        }

        // [Fact]
        // public void CheckBookEntry()
        // {
        //     var book = new Book("Book 1");
        //     var value = 101;
            

        //     Assert.Equal("Invalid Value", value);
        // }
        // private void AddGrade(Book book, int val)
        // {
        //     book.AddGrade(val);
        // }
    }
}
