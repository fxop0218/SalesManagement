using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

#nullable disable

namespace SalesManagment.Migrations
{
        public partial class AddSeedDb : Migration
    {
        const string ADMIN_ROLE_GUID = "7975b55b-dec5-423b-a3ed-3413d857fd43";
        const string SM_ROLE_GUID = "7c0e9280-2f34-4310-a0f7-c4c36ddcc50b";
        const string TL_ROLE_GUID = "7b4afbe0-7d23-44da-8c73-26aa72394a39";
        const string SR_ROLE_GUID = "18537db3-3fdb-43bd-ad34-57b74c7e7bda";

        const string ADMIN_USER_GUID = "1cc371d2-9413-49cc-ae29-4873ab0d7fc3";
        const string SM_USER_GUID = "4c5bce01-5c6c-46c6-8082-cfc14adcc997";
        const string TL_USER_GUID = "285cd1cd-39ea-4375-99f0-1b1b83f180d7";
        const string SR1_USER_GUID = "1c76403a-b24b-454c-931d-97b939b6df12";
        const string SR2_USER_GUID = "4e32ff3c-0652-4514-92b0-267822a65a7d";
        const string SR3_USER_GUID = "9e478ada-8c31-48f1-b199-be2ebab9df49";
        const string SR4_USER_GUID = "754e8eba-2c89-42c9-b03b-8ff887a5dee9";


        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var passwordHash = hasher.HashPassword(null, "Password1!");

            AddUser(migrationBuilder, "admin@oexl.com", passwordHash, ADMIN_USER_GUID);

            AddUser(migrationBuilder, "bob.jones@oexl.com", passwordHash, SM_USER_GUID);

            AddUser(migrationBuilder, "henry.andrews@oexl.com", passwordHash, TL_USER_GUID);

            AddUser(migrationBuilder, "olivia.mills@oexl.com", passwordHash, SR1_USER_GUID);
            AddUser(migrationBuilder, "noah.robinson@oexl.com", passwordHash, SR2_USER_GUID);
            AddUser(migrationBuilder, "benjamin.lucas@oexl.com", passwordHash, SR3_USER_GUID);
            AddUser(migrationBuilder, "sarah.henderson@oexl.com", passwordHash, SR4_USER_GUID);

            AddRole(migrationBuilder, "Admin", ADMIN_ROLE_GUID);
            AddRole(migrationBuilder, "SM", SM_ROLE_GUID);
            AddRole(migrationBuilder, "TL", TL_ROLE_GUID);
            AddRole(migrationBuilder, "SR", SR_ROLE_GUID);

            AddUserToRole(migrationBuilder, ADMIN_USER_GUID, ADMIN_ROLE_GUID);
            AddUserToRole(migrationBuilder, SM_USER_GUID, SM_ROLE_GUID);

            AddUserToRole(migrationBuilder, TL_USER_GUID, TL_ROLE_GUID);
            AddUserToRole(migrationBuilder, SR1_USER_GUID, SR_ROLE_GUID);
            AddUserToRole(migrationBuilder, SR2_USER_GUID, SR_ROLE_GUID);
            AddUserToRole(migrationBuilder, SR3_USER_GUID, SR_ROLE_GUID);
            AddUserToRole(migrationBuilder, SR4_USER_GUID, SR_ROLE_GUID);
        }

        /// <inheritdoc />
        private void AddUser(MigrationBuilder migrationBuilder, string email, string passwordHash, string userGuid)
        {
            StringBuilder sb = new StringBuilder();

            string emailCaps = email.ToUpper();

            sb.AppendLine("INSERT INTO AspNetUsers(Id, UserName, NormalizedUserName,Email,EmailConfirmed,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled,AccessFailedCount,NormalizedEmail,PasswordHash,SecurityStamp)");
            sb.AppendLine("VALUES(");
            sb.AppendLine($"'{userGuid}'");
            sb.AppendLine($",'{email}'");
            sb.AppendLine($",'{emailCaps}'");
            sb.AppendLine($",'{email}'");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine($",'{emailCaps}'");
            sb.AppendLine($", '{passwordHash}'");
            sb.AppendLine(", ''");
            sb.AppendLine(")");

            migrationBuilder.Sql(sb.ToString());
        }
        private void AddRole(MigrationBuilder migrationBuilder, string roleName, string roleGuid)
        {
            string roleNameCaps = roleName.ToUpper();

            migrationBuilder.Sql($"INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('{roleGuid}','{roleName}','{roleNameCaps}')");


        }

        private void AddUserToRole(MigrationBuilder migrationBuilder, string userGuid, string roleGuid)
        {
            migrationBuilder.Sql($"INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('{userGuid}','{roleGuid}')");


        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            RemoveUser(migrationBuilder, ADMIN_USER_GUID, ADMIN_ROLE_GUID);
            RemoveUser(migrationBuilder, SM_USER_GUID, SM_ROLE_GUID);
            RemoveUser(migrationBuilder, TL_USER_GUID, TL_ROLE_GUID);
            RemoveUser(migrationBuilder, SR1_USER_GUID, SR_ROLE_GUID);
            RemoveUser(migrationBuilder, SR2_USER_GUID, SR_ROLE_GUID);
            RemoveUser(migrationBuilder, SR3_USER_GUID, SR_ROLE_GUID);
            RemoveUser(migrationBuilder, SR4_USER_GUID, SR_ROLE_GUID);

            RemoveRole(migrationBuilder, ADMIN_ROLE_GUID);
            RemoveRole(migrationBuilder, SM_ROLE_GUID);
            RemoveRole(migrationBuilder, TL_ROLE_GUID);
            RemoveRole(migrationBuilder, SR_ROLE_GUID);
        }
        private void RemoveUser(MigrationBuilder migrationBuilder, string userGuid, string roleGuid)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId = '{userGuid}' AND RoleId = '{roleGuid}'");

            migrationBuilder.Sql($"DELETE FROM AspNetUsers WHERE Id = '{userGuid}'");
        }
        private void RemoveRole(MigrationBuilder migrationBuilder, string roleGuid)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id = '{roleGuid}'");
        }
    }
}
