using Microsoft.AspNetCore.Identity;
using Roads.Data;
using System.Runtime.CompilerServices;

namespace Roads.Helpers.Seeders
{
    public class UserRoleSeeder
    {
        private readonly RoadsContext _roadsContext;

        public UserRoleSeeder(RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
        }   
    
        public void SeedInitialUserRole()
        {
            if(!_roadsContext.UserRoles.Any())
            {
                var userrole1 = new IdentityUserRole<Guid>()
                {
                    RoleId = new Guid("2fd14c5a-e126-4b33-961b-ad9e1674799a"),
                    UserId = new Guid("65006866-8d62-42d8-8d32-3494b5860b99")
                };

                var userrole2 = new IdentityUserRole<Guid>()
                {
                    RoleId = new Guid("581f995a-b150-4337-a473-e3ff50c3c784"),
                    UserId = new Guid("bd9de8d9-1609-44ff-b95a-bce8e2d0edf0")
                };

                var userrole3 = new IdentityUserRole<Guid>()
                {
                    RoleId = new Guid("aac5dc91-2f46-42e6-bc73-3d91594ca01b"),
                    UserId = new Guid("49f42890-0eef-417f-aa55-3fede394be8d")
                };

                _roadsContext.UserRoles.Add(userrole1);
                _roadsContext.UserRoles.Add(userrole2);
                _roadsContext.UserRoles.Add(userrole3);
                _roadsContext.SaveChanges();

            }
        }
    }
}
