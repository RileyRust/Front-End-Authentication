using Front_EndAPI.Models;

namespace Front_EndAPI.Services
{
    public static class MockUsers
    {
        public static readonly Dictionary<string, (string Password, List<Roles> Roles)> Users =
            new()
            {
                ["alice"] = ("password123", new List<Roles> { Roles.ViewDashboard, Roles.EditUsers }),
                ["bob"] = ("password456", new List<Roles> { Roles.ViewDashboard })
            };
    }
}
