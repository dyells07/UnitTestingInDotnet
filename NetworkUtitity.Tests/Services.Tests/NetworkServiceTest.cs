using Xunit;
using NetworkUtility.Services;

namespace NetworkUtility.Tests
{
    public class NetworkServiceTest
    {
        [Fact]
        public void NetworkService_SendPing_ReturnsExpectedStatusCodes()
        {
            // Arrange 
            var pingService = new NetworkService();

            // Act
            var successResult = pingService.SendPing();

            // Assert
            Assert.Equal(200, successResult); // Successful ping
        }
    }
}
