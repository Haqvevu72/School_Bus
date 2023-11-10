using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Context.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cars_Number",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Parents",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Drivers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Cars",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6772), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6169), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6178), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6187), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6192), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6201), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6209), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6218), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6227), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7044), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7057), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7062), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7071), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7080), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7089), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7093), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7102), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7111), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7120), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7579), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7588), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7606), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7615), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7624), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7633), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7642), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7651), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7669), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7678), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7687), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7691), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7709), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7718), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7727), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7736), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7745), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7758), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7767), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7231), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7245), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7254), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7263), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7272), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7276), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7285), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7294), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7303), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7312), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4902), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4911), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4920), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4938), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4947), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4955), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4964), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4969), new DateTime(2023, 11, 9, 22, 25, 51, 662, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6289), new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6298), new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6307), new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6325), new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6334), new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6343), new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6361), new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6365), new DateTime(2023, 11, 9, 22, 25, 51, 661, DateTimeKind.Local).AddTicks(6370) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Cars",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1430), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(795), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(798), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(800), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(803), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(805), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(807), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(809), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(811), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(813), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(816), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1512), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1514), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1516), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1518), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1520), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1522), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1525), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1527), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1529), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1739), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1741), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1744), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1746), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1749), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1751), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1754), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1757), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1760), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1763), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1766), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1774), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1777), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1779), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1782), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1784), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1786), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1789), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1792), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1795), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1797), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1799), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1802), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1597), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1599), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1601), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1606), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1614), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1617), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1619), new DateTime(2023, 11, 6, 15, 57, 40, 774, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9794), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9797), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9799), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9801), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9804), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9806), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9808), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9810), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9813), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9815), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2612), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2615), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2618), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2620), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2623), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2625), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2627), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2633), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2635), new DateTime(2023, 11, 6, 15, 57, 40, 773, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_Number",
                table: "Cars",
                column: "Number",
                unique: true);
        }
    }
}
