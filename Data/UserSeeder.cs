using Microsoft.AspNetCore.Identity;

namespace SIMS.Data
{
    public class UserSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            // Seed Roles
            string[] roles = { "Admin", "Student", "Lecture" };
            foreach (var roleName in roles)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            // Seed Admin User
            string adminEmail = "admin@admin.com";
            string adminPassword = "123123";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                var user = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    Name = "System Adminstractor",
                    EmailConfirmed = true
                };
                var createAdminResult = await userManager.CreateAsync(user, adminPassword);
                if (createAdminResult.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }
    } 
}
