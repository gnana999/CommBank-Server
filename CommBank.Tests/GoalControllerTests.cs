using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommBank.Controllers;
using CommBank.Models;

namespace CommBank.Tests
{
    public class GoalControllerTests
    {
        private readonly FakeCollections collections;

        public GoalControllerTests()
        {
            collections = new FakeCollections();
        }

        [Fact]
        public async Task GetForUser_ReturnsGoals()
        {
            // Arrange
            var controller = new GoalController(collections);
            var userId = "test-user-id";

            // Act
            var result = await controller.GetGoalsForUser(userId);

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<Goal>>(result.Value);
        }
    }
}