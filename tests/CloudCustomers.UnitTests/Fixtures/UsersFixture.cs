using CloudCustomers.Lib.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new()
        {
            new()
            {
                Id = 1,
                Name = "Test User 1",
                Address = new Address()
                {
                    Street = "123 Main St",
                    City = "Madison",
                    ZipCode = "53704"
                },
                Email = "test.user.3@test.com"
            },
            new()
            {
                Id = 2,
                Name = "Test User 2",
                Address = new Address()
                {
                    Street = "123 Main St",
                    City = "Madison",
                    ZipCode = "53704"
                },
                Email = "test.user.3@test.com"
            },
            new()
            {
                Id = 3,
                Name = "Test User 3",
                Address = new Address()
                {
                    Street = "123 Main St",
                    City = "Madison",
                    ZipCode = "53704"
                },
                Email = "test.user.3@test.com"
            },
        };
    }
}
