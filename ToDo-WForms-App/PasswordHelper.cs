using BCrypt.Net;

namespace ToDo_WForms_App
{
    public static class PasswordHelper
    {
        // Hash the password
        public static string HashPassword(string plainPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }

        // Verify the password against the hash
        public static bool VerifyPassword(string plainPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, hashedPassword);
        }
    }
}
