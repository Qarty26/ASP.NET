using Microsoft.AspNetCore.Identity;
using Roads.Data;

namespace Roads.Helpers.Seeders
{
    public class RoleSeeder
    {
        private readonly RoadsContext _roadsContext;

        public RoleSeeder(RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
        }

        public void SeedInitialRoles()
        {
            if(!_roadsContext.Roles.Any())
            {
                var role1 = new IdentityRole<Guid>()
                {
                    Id = new Guid("2fd14c5a-e126-4b33-961b-ad9e1674799a"),
                    Name = "Regular",
                    NormalizedName = "Regular".ToUpper()
                };

                var role2 = new IdentityRole<Guid>()
                {
                    Id = new Guid("581f995a-b150-4337-a473-e3ff50c3c784"),
                    Name = "Vip",
                    NormalizedName = "Vip".ToUpper()
                };

                var role3 = new IdentityRole<Guid>()
                {
                    Id = new Guid("aac5dc91-2f46-42e6-bc73-3d91594ca01b"),
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper()
                };

                _roadsContext.Roles.Add(role1);
                _roadsContext.Roles.Add(role2);
                _roadsContext.Roles.Add(role3);
                _roadsContext.SaveChanges();

            }

        }
    }
}
