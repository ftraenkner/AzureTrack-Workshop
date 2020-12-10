using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RMotownFestival.Api.Migrations
{
    public partial class SeedDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "FestivalId", "ImagePath", "Name", "Website" },
                values: new object[,]
                {
                    { 1, null, "dianaross.jpg", "Diana Ross", "http://www.dianaross.co.uk/indexb.html" },
                    { 2, null, "thecommodores.jpg", "The Commodores", "http://en.wikipedia.org/wiki/Commodores" },
                    { 3, null, "steviewonder.jpg", "Stevie Wonder", "http://www.steviewonder.net/" },
                    { 4, null, "lionelrichie.jpg", "Lionel Richie", "http://lionelrichie.com/" },
                    { 5, null, "marvingaye.jpg", "Marvin Gaye", "http://www.marvingayepage.net/" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Stages",
                columns: new[] { "Id", "Description", "FestivalId", "Name" },
                values: new object[,]
                {
                    { 1, "A music festival is a festival oriented towards music that is sometimes presented with a theme such as musical genre, nationality or locality of musicians, or holiday. They are commonly held outdoors, and are often inclusive of other attractions such as food and merchandise vending machines, performance art, and social activities. Large music festivals such as Lollapalooza are constructed around well known main stage acts and lesser known musicians and bands on side stages. Many festivals are annual, or repeat at some other interval, and have modular staging of many types. Each year Lollapalooza often features multiple acts on its main and side stages.", null, "Main Stage" },
                    { 2, "A music festival is a festival oriented towards music that is sometimes presented with a theme such as musical genre, nationality or locality of musicians, or holiday. They are commonly held outdoors, and are often inclusive of other attractions such as food and merchandise vending machines, performance art, and social activities. Large music festivals such as Lollapalooza are constructed around well known main stage acts and lesser known musicians and bands on side stages. Many festivals are annual, or repeat at some other interval, and have modular staging of many types. Each year Lollapalooza often features multiple acts on its main and side stages.", null, "Orange Room" },
                    { 3, "A music festival is a festival oriented towards music that is sometimes presented with a theme such as musical genre, nationality or locality of musicians, or holiday. They are commonly held outdoors, and are often inclusive of other attractions such as food and merchandise vending machines, performance art, and social activities. Large music festivals such as Lollapalooza are constructed around well known main stage acts and lesser known musicians and bands on side stages. Many festivals are annual, or repeat at some other interval, and have modular staging of many types. Each year Lollapalooza often features multiple acts on its main and side stages.", null, "StarDust" },
                    { 4, "A music festival is a festival oriented towards music that is sometimes presented with a theme such as musical genre, nationality or locality of musicians, or holiday. They are commonly held outdoors, and are often inclusive of other attractions such as food and merchandise vending machines, performance art, and social activities. Large music festivals such as Lollapalooza are constructed around well known main stage acts and lesser known musicians and bands on side stages. Many festivals are annual, or repeat at some other interval, and have modular staging of many types. Each year Lollapalooza often features multiple acts on its main and side stages.", null, "Pink Room" }
                });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "LineUpId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ScheduleItems",
                columns: new[] { "Id", "ArtistId", "IsFavorite", "ScheduleId", "StageId", "Time" },
                values: new object[,]
                {
                    { 1, 1, false, 1, 1, new DateTime(1972, 7, 1, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, false, 1, 1, new DateTime(1972, 7, 1, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, false, 1, 1, new DateTime(1972, 7, 2, 20, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 4, false, 1, 1, new DateTime(1972, 7, 2, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, false, 1, 2, new DateTime(1972, 7, 1, 22, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, false, 1, 2, new DateTime(1972, 7, 2, 22, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 5, false, 1, 4, new DateTime(1972, 7, 1, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 5, false, 1, 4, new DateTime(1972, 7, 2, 20, 45, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Festivals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ScheduleItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ScheduleItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ScheduleItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ScheduleItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ScheduleItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ScheduleItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ScheduleItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ScheduleItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stages",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
