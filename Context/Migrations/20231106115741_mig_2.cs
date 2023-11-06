using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Context.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Cars",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cars_Number",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5425), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5300), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5303), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5306), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5308), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5311), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5313), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5315), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5317), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5322), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5618), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5620), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5623), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5625), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5627), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5629), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5631), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5633), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5636), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5638), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5806), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5812), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5815), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5817), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5825), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5830), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5833), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5835), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5838), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5844), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5847), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5849), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5851), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5854), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5857), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5859), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5861), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5863), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5717), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5720), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5727), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5732), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5735), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5737), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5739), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4253), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4256), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4258), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4260), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4263), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4267), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4272), new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7025), new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7029), new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7031), new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7034), new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7036), new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7038), new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7041), new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7043), new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7045), new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7048), new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7049) });
        }
    }
}
