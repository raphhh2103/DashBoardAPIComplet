using Microsoft.EntityFrameworkCore.Migrations;

namespace DashBoardDAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserEntity",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pseudo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    PssWd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_UserEntity_Project_ProjectEntityId",
                        column: x => x.ProjectEntityId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BoardEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserOwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoardEntity_UserEntity_UserOwnerId",
                        column: x => x.UserOwnerId,
                        principalTable: "UserEntity",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamEntityUserEntity",
                columns: table => new
                {
                    TeamUsersId = table.Column<int>(type: "int", nullable: false),
                    TeamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamEntityUserEntity", x => new { x.TeamUsersId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_TeamEntityUserEntity_TeamEntity_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "TeamEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamEntityUserEntity_UserEntity_TeamUsersId",
                        column: x => x.TeamUsersId,
                        principalTable: "UserEntity",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BoardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentEntity_BoardEntity_BoardId",
                        column: x => x.BoardId,
                        principalTable: "BoardEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoardEntity_Title",
                table: "BoardEntity",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_BoardEntity_UserOwnerId",
                table: "BoardEntity",
                column: "UserOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentEntity_BoardId",
                table: "ContentEntity",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamEntityUserEntity_TeamsId",
                table: "TeamEntityUserEntity",
                column: "TeamsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_ProjectEntityId",
                table: "UserEntity",
                column: "ProjectEntityId");

            migrationBuilder.CreateIndex(
                name: "UK_Email",
                table: "UserEntity",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Pseudo",
                table: "UserEntity",
                column: "Pseudo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentEntity");

            migrationBuilder.DropTable(
                name: "TeamEntityUserEntity");

            migrationBuilder.DropTable(
                name: "BoardEntity");

            migrationBuilder.DropTable(
                name: "TeamEntity");

            migrationBuilder.DropTable(
                name: "UserEntity");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
