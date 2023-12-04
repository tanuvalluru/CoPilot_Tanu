using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class UserControllerTests
{
    private UserController _controller;

    public UserControllerTests()
    {
        // Initialize UserController here. You might need to mock dependencies if any.
        _controller = new UserController();
    }

    [Fact]
    public async Task Get_ReturnsUserWithGivenId()
    {
        // Arrange
        var testId = 1;

        // Act
        var result = await _controller.Get(testId);

        // Assert
        Assert.Equal($"User with ID {testId}", result.Value);
    }

    [Fact]
    public async Task Post_CreatesNewUser()
    {
        // Arrange
        var testValue = "Test User";

        // Act
        var result = await _controller.Post(testValue);

        // Assert
        Assert.Equal($"New user created: {testValue}", result.Value);
    }

    [Fact]
    public async Task Put_UpdatesExistingUser()
    {
        // Arrange
        var testId = 1;
        var testValue = "Updated User";

        // Act
        var result = await _controller.Put(testId, testValue);

        // Assert
        Assert.Equal($"User with ID {testId} updated: {testValue}", result.Value);
    }
}