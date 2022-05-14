using AspNetCore_GitHub_Action_Test_Reporter.Service;
using System;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest
{
    public class SampleServiceTest
    {

        [Fact]
        public void Test_DoSomthing_result_is_true()
        {
            // Arrange
            var service = new SampleService();

            // Action
            var result = service.DoSomthing();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Test_ThrowError_throw_ex()
        {
            // Arrange
            var service = new SampleService();

            // Action
            Action action = () => service.ThrowError();

            // Arrange
            Assert.ThrowsAny<Exception>(action);
        }

        [Fact]
        public void Test_Add_is_correct()
        {
            // Arrange
            var service = new SampleService();

            // Action
            var result = service.Add(10, 5);

            // Assert
            Assert.True(result == 15);
        }

        [Fact]
        public void Test_Sub_is_correct()
        {
            // Arrange
            var service = new SampleService();

            // Action
            var result = service.Sub(10, 5);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
