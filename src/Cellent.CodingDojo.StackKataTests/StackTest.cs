using Cellent.CodingDojo.StackKata;
using System;
using Xunit;
using FluentAssertions;
using System.Linq;

namespace Cellent.CodingDojo.StackKataTests
{
    public class StackTest
    {
        [Fact]
        public void Stack_ShouldCreatedWithoutException()
        {
            Action action = () => new Stack<int>();

            action.ShouldNotThrow();
        }

        [Fact]
        public void Stack_PushShouldCalledWithoutException()
        {
            var sut = new Stack<int>();
            var value = 1;
            Action action = () => sut.Push(value);
            action.ShouldNotThrow();
        }

        [Fact]
        public void Stack_PopShouldReturnOneAfterOneWasPushed()
        {
            var sut = new Stack<int>();
            var expected = 1;

            sut.Push(expected);
            var actual = sut.Pop();

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Stack_PopShouldThrowOnEmptyValueType()
        {
            var sut = new Stack<int>();

            Action action = () => sut.Pop();
            action.ShouldThrow<InvalidOperationException>();
        }

        [Fact]
        public void Stack_PopShouldThrowOnEmtpyReference()
        {
            var sut = new Stack<object>();

            Action action = () => sut.Pop();
            action.ShouldThrow<InvalidOperationException>();
        }

        [Fact]
        public void Stack_ShouldReturn2elementsOnPopAfter2ElementsPushed()
        {
            var sut = new Stack<int>();
            int first = 1;
            sut.Push(first);
            int second = 2;
            sut.Push(second);

            int actual = sut.Pop();
            Assert.Equal(second, actual);

            actual = sut.Pop();
            Assert.Equal(first, actual);
        }

        [Fact]
        public void Stack_ReturnsElementsInTheOrderTheyWerePushed()
        {
            var sut = new Stack<int>();
            var values = Enumerable.Range(1, 10).ToList();
            var expected = values.Last();

            values.ForEach(v => sut.Push(v));
            sut.Push(5);
            sut.Pop();

            var actual = sut.Pop();

            Assert.Equal(expected, actual);
        }
    }
}


