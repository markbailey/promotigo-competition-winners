using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class DummyDataV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1f888604-02ae-4f98-ba63-3dfc2d729bde"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("449e957d-15c8-40c8-9f68-bcc4288a7bcc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("524d9afa-3a6e-4640-aaf5-71febc4347cf"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("62538378-de06-4da0-b361-8f27f5430386"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("d63d6620-ecc4-49f8-9f37-e2e2bddf494d"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("f2413a3b-1058-45ff-bd46-07df8bbbbebb"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { new Guid("1a5ab7b3-433a-4ced-a0d1-eeb27f711435"), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3743), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3789), "Brooks" },
                    { new Guid("4e65bbb3-64ad-4006-9a1b-fd1769f28754"), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3792), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3793), "Coca Cola" },
                    { new Guid("6d6e860a-d170-4175-8136-1ab4c313ca21"), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3795), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3797), "Ben & Jerrys" }
                });

            migrationBuilder.InsertData(
                table: "CompetitionEntries",
                columns: new[] { "Id", "CompetitionId", "DateCreated", "DateUpdated", "IsWinner", "PlayerId" },
                values: new object[,]
                {
                    { new Guid("016ee2dd-18b5-480e-9dcb-d8f3397b718e"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6110), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6111), false, new Guid("71e8c13a-8f94-49ca-a5cd-b28b8646b178") },
                    { new Guid("01dfddac-5a09-4c36-81f7-7bbe2cd95f2c"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5761), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5762), false, new Guid("d9465ba6-8a98-44ee-89af-b8e53c53ee2e") },
                    { new Guid("04f83094-41e0-4f17-8756-ba202fea3cff"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5899), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5900), false, new Guid("bafdbb35-ab1b-42d5-a127-2757ff31b3aa") },
                    { new Guid("0524e56f-3872-44a3-a677-1f384e2a0805"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6241), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6242), false, new Guid("2f6585bc-dd32-4303-a640-1fc0c874a66f") },
                    { new Guid("05ad49d9-04db-4085-8e68-5b2ab5abaae1"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6228), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6230), false, new Guid("ea599c07-3902-47fd-8822-6878c8aa04b4") },
                    { new Guid("061770b3-cc63-4ea7-8b91-45b129a2e1f1"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5672), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5673), false, new Guid("1436af82-a8c3-46f5-938c-e3ef7729e9d5") },
                    { new Guid("07282068-98e2-4e42-9561-aca2a7a14f9a"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6334), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6335), false, new Guid("59781431-969d-4057-89aa-103e010c23c6") },
                    { new Guid("084c330c-8d3d-4d44-8385-e80525b9c789"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6263), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6264), false, new Guid("42f91b0f-c72c-4ded-a03d-974f5aa31c70") },
                    { new Guid("0858102e-2e2e-468d-8b74-3a4582037601"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6050), false, new Guid("b20ccb2d-205a-42ef-94c5-6e80a47b5d8e") },
                    { new Guid("085bdd43-8d55-482a-8c0b-7afe8b5c1f09"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5646), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5648), false, new Guid("d0c2ff00-0264-4490-82f5-0871d5355361") },
                    { new Guid("08df996e-9c4c-4a8b-a8e7-c67157ddd06e"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5812), false, new Guid("b20ccb2d-205a-42ef-94c5-6e80a47b5d8e") },
                    { new Guid("0b78e1f7-6663-4400-a429-48b97b9a8073"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6286), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6287), false, new Guid("301d19f2-1f58-460e-b4b4-66c7a438ba62") },
                    { new Guid("15176e22-d90e-4da2-a5d1-d906b791cfd4"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6220), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6222), false, new Guid("7816c680-1d79-40e4-95e6-3f727473b352") },
                    { new Guid("15204dc7-8434-41b7-bce2-f4db4d639290"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6062), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6064), false, new Guid("639cf491-c4c1-4b80-b1f0-014e7e6bf22e") },
                    { new Guid("1640e153-0f80-4fca-aafb-fc39a4e32d26"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5934), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5935), false, new Guid("39c6cabf-68ce-464f-94c1-eba1e212a012") },
                    { new Guid("19f9ab7d-232d-4ace-ae18-ea5460e5153a"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6120), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6121), false, new Guid("59781431-969d-4057-89aa-103e010c23c6") },
                    { new Guid("1a4a7259-7270-4cef-9772-517e29d0e1c8"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5771), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5773), false, new Guid("1f47891f-dfde-40ff-a1ee-d2d223a001f5") },
                    { new Guid("1cc00b86-bb96-4558-90df-bbb7f5e4c623"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5795), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5796), false, new Guid("5e94d73c-6924-4882-a2c4-6fb47659fa70") },
                    { new Guid("1fd295d6-7104-421e-adbc-3bd92b153afd"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6149), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6150), false, new Guid("053bc7a9-8c52-4938-85a1-47c5f1ac1944") },
                    { new Guid("2aea7db2-eb1e-48b3-97a8-f31b5cb3c117"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5822), false, new Guid("0afd8506-babc-49ec-8614-4f62ba4071d5") },
                    { new Guid("2dfa99a6-3c29-416e-a771-3354c6f66926"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6029), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6030), false, new Guid("f7dac28c-5c83-4925-b334-c7db7680c988") },
                    { new Guid("2e819cb6-8d14-4da1-8ccc-fb27bfd575fe"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5853), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5855), false, new Guid("71e8c13a-8f94-49ca-a5cd-b28b8646b178") },
                    { new Guid("2ed017e0-8f02-4323-8461-49ef78b6f39e"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5777), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5778), false, new Guid("42f91b0f-c72c-4ded-a03d-974f5aa31c70") },
                    { new Guid("353b116d-f009-4b2f-8088-77d761836876"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5966), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5967), false, new Guid("c2d3b691-4962-4bba-86ce-edb3b030dd8d") },
                    { new Guid("362e4191-5bc6-47de-8afa-bef38dbe01f7"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6182), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6184), false, new Guid("39c6cabf-68ce-464f-94c1-eba1e212a012") },
                    { new Guid("36a73a1e-5c6c-41a0-8349-8256dbffc5ad"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6267), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6269), false, new Guid("f7dac28c-5c83-4925-b334-c7db7680c988") },
                    { new Guid("38845614-ae6c-46b9-9860-ed1b3ab78603"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6280), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6281), false, new Guid("2790301b-54b0-4360-847c-d370851a5146") },
                    { new Guid("40caec20-445a-4ce7-b62d-1f3b9ff8f92a"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6202), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6204), false, new Guid("8816a160-9b0b-453b-a564-c5f5a7f179d8") },
                    { new Guid("41cc5661-622c-4d9a-9134-edf3f1cb8706"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6315), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6316), false, new Guid("7b4381d7-3ba9-4fbc-bff3-e7f54dbc8625") },
                    { new Guid("430e5fd0-109b-4643-8df2-07bb7000c29b"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5867), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5868), false, new Guid("2ababd28-3d1d-49a5-a91c-f68c42c809c5") },
                    { new Guid("43f60552-3e29-4c6b-822d-51d36ce0f352"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6190), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6192), false, new Guid("c0ad6371-94c1-4556-bc4a-c20b83cf13de") },
                    { new Guid("49c26d66-e5cc-4b6e-b260-b07bd900d5db"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6210), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6212), false, new Guid("ff7e50ef-778b-4d22-be3c-b9afbf7b93c9") },
                    { new Guid("4a6a39e7-0c2f-4061-bdf6-95e9816e3fac"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5719), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5720), false, new Guid("7816c680-1d79-40e4-95e6-3f727473b352") },
                    { new Guid("530319cf-f2cf-4e65-bf31-0bf77e4e5b77"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5905), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5907), false, new Guid("9007f20e-2dbb-4a16-a133-7876f36e772d") },
                    { new Guid("54bcf09d-4b4e-402d-bfe0-af24d03ce22e"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6007), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6009), false, new Guid("de7b471b-af6c-4155-9bf5-a4d964678bc6") },
                    { new Guid("559cd6b7-5ca5-4f1d-9b35-70f0e00907e4"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5657), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5659), false, new Guid("3034c1dc-458e-4a63-91a1-5f4162d50cc6") },
                    { new Guid("55df1479-4976-415c-bc55-5d8dbb987fa9"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6116), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6117), false, new Guid("d60a9162-4fc2-4265-8d12-291ab344432f") },
                    { new Guid("5646850b-3b0f-43a8-b6ad-fa38b9cc46a2"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5729), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5731), false, new Guid("ea599c07-3902-47fd-8822-6878c8aa04b4") },
                    { new Guid("57e9adba-c95e-499b-995b-896c2336ddfe"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6199), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6200), false, new Guid("9ed633ed-942f-4be6-a627-394e0dcc0fa0") },
                    { new Guid("5838843b-7c05-4538-8451-8338a6a7b9dd"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5844), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5846), false, new Guid("7b4381d7-3ba9-4fbc-bff3-e7f54dbc8625") },
                    { new Guid("5964add5-23bd-4805-a14c-5d394188abc5"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6206), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6208), false, new Guid("c2d3b691-4962-4bba-86ce-edb3b030dd8d") },
                    { new Guid("5c0abc9a-0e8a-45b7-8680-972bc4673b36"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5849), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5851), false, new Guid("e2e38434-2d6a-4040-a6e3-d0f2934c9597") },
                    { new Guid("5fc6693d-feef-4be7-a2e7-12091000dd43"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6298), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6300), false, new Guid("0afd8506-babc-49ec-8614-4f62ba4071d5") },
                    { new Guid("5fd327a3-6de8-482a-9234-19bd0f0b286d"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6038), false, new Guid("5e94d73c-6924-4882-a2c4-6fb47659fa70") },
                    { new Guid("5ff8d2c7-3ac5-4b52-927a-8ab5d670f4e9"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5919), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5921), false, new Guid("d0c2ff00-0264-4490-82f5-0871d5355361") },
                    { new Guid("6252c66b-3af1-428e-99a9-7d2ca92a4052"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6003), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6005), false, new Guid("2f6585bc-dd32-4303-a640-1fc0c874a66f") },
                    { new Guid("62b07d7a-d695-4ffb-bf6f-d09c4a05cbef"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6105), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6107), false, new Guid("e2e38434-2d6a-4040-a6e3-d0f2934c9597") },
                    { new Guid("63be27a7-2a4f-41b1-9607-d343e9dd78b0"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6021), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6022), false, new Guid("1f47891f-dfde-40ff-a1ee-d2d223a001f5") },
                    { new Guid("64114694-e376-4d3f-a722-7a9a90860163"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6153), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6154), false, new Guid("bafdbb35-ab1b-42d5-a127-2757ff31b3aa") },
                    { new Guid("64c8a9bd-a5a3-4d7f-889c-3042dccd5953"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5861), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5863), false, new Guid("59781431-969d-4057-89aa-103e010c23c6") },
                    { new Guid("67a740e3-926f-47f0-bb93-2dcf55a95b5d"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5816), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5817), false, new Guid("e02f6c8d-0e0b-43f8-a6f4-148a3c46ed3c") },
                    { new Guid("685e8e7d-f80c-4dd6-aeab-3b6fce62f82a"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5875), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5876), false, new Guid("a642f3c5-4e96-4131-ad5c-52f5a6594e5f") },
                    { new Guid("6986a24e-02ff-4d68-b9eb-85df6fc2134f"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5628), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5629), false, new Guid("9007f20e-2dbb-4a16-a133-7876f36e772d") },
                    { new Guid("6ac81072-046e-47d4-8f5a-82edf6adf32e"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5663), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5664), false, new Guid("39c6cabf-68ce-464f-94c1-eba1e212a012") },
                    { new Guid("6bc18db7-50e7-4bb5-9875-79a46a491942"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5956), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5957), false, new Guid("9ed633ed-942f-4be6-a627-394e0dcc0fa0") },
                    { new Guid("6deefbb6-28e7-4047-ae71-fdb186f6f3f7"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5999), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6001), false, new Guid("3a97972b-976e-4787-b628-a15dc2e3bc32") },
                    { new Guid("6e13d48f-a4bb-4485-a01e-25523326f55a"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5737), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5738), false, new Guid("ae214892-1bb5-441c-a03a-a27f0210bcd9") },
                    { new Guid("6e542789-bc90-4381-ab2a-4d3df67d5864"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6157), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6158), false, new Guid("9007f20e-2dbb-4a16-a133-7876f36e772d") },
                    { new Guid("6ee0f001-b60a-49be-a550-774395441ed7"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6161), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6162), false, new Guid("dfca5d02-0c40-46ee-a674-89543d1b6f2e") },
                    { new Guid("6ee81f2d-1ecb-421e-98c4-c020ac0b9b5c"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5789), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5791), false, new Guid("2e7c3a53-7a0c-42e7-8ed0-bf8625762e7f") },
                    { new Guid("70934c39-8627-488f-8baa-6fc940d3feaf"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6276), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6277), false, new Guid("5e94d73c-6924-4882-a2c4-6fb47659fa70") },
                    { new Guid("712d72db-bc3f-40e2-adbf-b34876a449a5"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6033), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6034), false, new Guid("2e7c3a53-7a0c-42e7-8ed0-bf8625762e7f") },
                    { new Guid("71e0323a-abfa-409f-b47f-ef231151dd77"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5828), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5830), false, new Guid("639cf491-c4c1-4b80-b1f0-014e7e6bf22e") },
                    { new Guid("7494030d-5bbc-4214-b346-9db96b4a1464"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6338), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6339), false, new Guid("2ababd28-3d1d-49a5-a91c-f68c42c809c5") },
                    { new Guid("77aaa49a-fd7c-4ce0-844e-959066cc530d"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6325), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6327), false, new Guid("71e8c13a-8f94-49ca-a5cd-b28b8646b178") },
                    { new Guid("78004f6e-bf21-430b-b958-e5401d1cdac6"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6224), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6226), false, new Guid("ebca884c-abef-4d3a-b2d6-b6ef87c94af8") },
                    { new Guid("79e8060f-f977-4001-be3c-f62fd26ecbab"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6128), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6129), false, new Guid("f7cd5a3f-15fe-441a-9599-3d76c11a73af") },
                    { new Guid("7b6d6802-833b-4c13-8beb-34615ce3ae8d"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6026), false, new Guid("42f91b0f-c72c-4ded-a03d-974f5aa31c70") },
                    { new Guid("7cf2acd3-7322-4b9b-b734-fb7f8b9583cd"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5929), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5931), false, new Guid("3034c1dc-458e-4a63-91a1-5f4162d50cc6") },
                    { new Guid("7cfafca1-d821-4ea6-af81-04da8a277762"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6070), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6072), false, new Guid("6b6c3be7-2856-4e32-a4bd-7b07390ce9a9") },
                    { new Guid("7d71da35-29f7-406e-8e2d-e03ae1b0eb27"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6233), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6234), false, new Guid("ae214892-1bb5-441c-a03a-a27f0210bcd9") },
                    { new Guid("7d8bc2ce-b1c4-4065-8b1a-76bc96737ca7"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6135), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6137), false, new Guid("a17c4417-61a2-4932-b988-0cbffae49940") },
                    { new Guid("832e5fae-32a9-43b9-8e3d-a90beedfc3e3"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6169), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6170), false, new Guid("d0c2ff00-0264-4490-82f5-0871d5355361") },
                    { new Guid("84775e0a-9fdd-4986-9ef8-623b4fab562e"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6330), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6331), false, new Guid("d60a9162-4fc2-4265-8d12-291ab344432f") },
                    { new Guid("84aee634-58f1-43a2-a8eb-cdbeeb29304d"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5950), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5952), false, new Guid("5557f670-3330-4144-9ea1-f47c2a45ff7f") },
                    { new Guid("8575df94-d0da-4165-8188-cb4d55bcd01c"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5652), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5653), false, new Guid("ed927e79-fdb1-4a57-9bcc-7bcaebe43154") },
                    { new Guid("8786fb1c-4fe3-40cc-80b1-22da7a9b18b9"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6251), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6252), false, new Guid("d9465ba6-8a98-44ee-89af-b8e53c53ee2e") },
                    { new Guid("8a8d7a9d-32c7-4701-a58f-d7b9f958b670"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5910), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5911), false, new Guid("dfca5d02-0c40-46ee-a674-89543d1b6f2e") },
                    { new Guid("8b67ce6b-b65a-4d4e-87d5-145cb2dfa485"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5991), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5993), false, new Guid("ea599c07-3902-47fd-8822-6878c8aa04b4") },
                    { new Guid("8da0911b-3735-495d-ab12-d8fb758b1932"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5677), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5679), false, new Guid("c0ad6371-94c1-4556-bc4a-c20b83cf13de") },
                    { new Guid("8e19c30f-eb45-42c0-a586-6f6716d0736b"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6186), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6188), false, new Guid("1436af82-a8c3-46f5-938c-e3ef7729e9d5") },
                    { new Guid("8f6c8061-0a89-4b41-8aa2-7bf19787ade3"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5884), false, new Guid("72dbc22c-72c9-49f5-9f0c-5d55e1754220") },
                    { new Guid("902ae2ee-9e2a-47a0-ae55-b670a9e01032"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5766), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5768), false, new Guid("c2dd9171-3128-4275-bc0c-04daba85c5c0") },
                    { new Guid("92b537ed-f9e1-481b-85c1-aa9e3a58fca5"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5914), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5916), false, new Guid("2c0f2ba0-3b52-4381-b6cb-dd1fa5b5ebe7") },
                    { new Guid("98d18f16-312c-4fcc-be3c-95466f2090ca"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6143), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6145), false, new Guid("7169de8d-f64b-4e78-afa3-56d02ed5e88a") },
                    { new Guid("99124208-c052-4842-aa23-546738e3d0e2"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5945), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5947), false, new Guid("c0ad6371-94c1-4556-bc4a-c20b83cf13de") },
                    { new Guid("999576ff-ff5e-4a3b-b4f0-265a4ee3cf92"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6124), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6125), false, new Guid("2ababd28-3d1d-49a5-a91c-f68c42c809c5") },
                    { new Guid("9a3ea4bc-aa2b-438f-9671-00831ce798b0"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5715), false, new Guid("c40098f4-e3a1-4d2d-a19e-5d4801299c6f") },
                    { new Guid("9bb79d6b-cfd4-4e1c-ab75-6d72e24af0e6"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5888), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5890), false, new Guid("7169de8d-f64b-4e78-afa3-56d02ed5e88a") },
                    { new Guid("9d4b07ff-3f22-469c-b957-8832fc840bd1"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6216), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6218), false, new Guid("c40098f4-e3a1-4d2d-a19e-5d4801299c6f") },
                    { new Guid("9e4fa869-de50-4e37-87a5-92e57e972b78"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5925), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5927), false, new Guid("ed927e79-fdb1-4a57-9bcc-7bcaebe43154") },
                    { new Guid("9f75955c-4cf6-48da-84cb-05a0795bc201"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6041), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6042), false, new Guid("2790301b-54b0-4360-847c-d370851a5146") },
                    { new Guid("9fe22cfa-e6a0-4f82-a9a2-9c5f4fe6b077"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6238), false, new Guid("3a97972b-976e-4787-b628-a15dc2e3bc32") },
                    { new Guid("a1897d44-e4fb-428b-94ef-22f98043da5b"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5833), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5834), false, new Guid("a86dab2e-5f86-486d-85dc-35298f75834b") },
                    { new Guid("a2463818-f11c-42b0-a10b-cffc6ee173b1"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6054), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6056), false, new Guid("e02f6c8d-0e0b-43f8-a6f4-148a3c46ed3c") },
                    { new Guid("a2a99e80-1ca6-4731-a909-cde095d76c21"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5976), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5978), false, new Guid("c40098f4-e3a1-4d2d-a19e-5d4801299c6f") },
                    { new Guid("a2e740a4-502b-4dec-8334-5c1a2630ca60"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5971), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5972), false, new Guid("ff7e50ef-778b-4d22-be3c-b9afbf7b93c9") },
                    { new Guid("a48510d1-2529-48c3-89c6-f87a7290f4b7"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5838), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5839), false, new Guid("6b6c3be7-2856-4e32-a4bd-7b07390ce9a9") },
                    { new Guid("a48f62aa-a395-4ac9-b921-edf584fbd5b1"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6259), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6261), false, new Guid("1f47891f-dfde-40ff-a1ee-d2d223a001f5") },
                    { new Guid("a4ecfd67-72a7-4d9c-916e-f40a1f21f1d2"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6290), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6291), false, new Guid("b20ccb2d-205a-42ef-94c5-6e80a47b5d8e") },
                    { new Guid("a844842d-c405-4ef2-a410-4297f2ab3f4c"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5611), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5613), false, new Guid("7169de8d-f64b-4e78-afa3-56d02ed5e88a") },
                    { new Guid("a87ed05b-69d7-4dbd-9f1d-36cd65323441"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5633), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5635), false, new Guid("dfca5d02-0c40-46ee-a674-89543d1b6f2e") },
                    { new Guid("ac66205b-b241-4eba-847d-482304bc4ec7"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5784), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5785), false, new Guid("f7dac28c-5c83-4925-b334-c7db7680c988") },
                    { new Guid("ac6fb38d-8bc4-4788-9858-452f28998465"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6058), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6060), false, new Guid("0afd8506-babc-49ec-8614-4f62ba4071d5") },
                    { new Guid("acbbaf5b-af15-4efc-9ce2-92bec91b59e7"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5724), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5726), false, new Guid("ebca884c-abef-4d3a-b2d6-b6ef87c94af8") },
                    { new Guid("ae74f964-4190-4632-9c83-ba2e0ceba3d6"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6345), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6347), false, new Guid("a642f3c5-4e96-4131-ad5c-52f5a6594e5f") },
                    { new Guid("b04c3165-e1b2-480c-bb50-e1d84a42c9f3"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6013), false, new Guid("d9465ba6-8a98-44ee-89af-b8e53c53ee2e") },
                    { new Guid("b2669a08-c09d-4a0c-a40d-8239ec393730"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5995), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5997), false, new Guid("ae214892-1bb5-441c-a03a-a27f0210bcd9") },
                    { new Guid("b8b431f7-7eb0-4ff5-a5b9-5091cd11cf79"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5641), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5643), false, new Guid("2c0f2ba0-3b52-4381-b6cb-dd1fa5b5ebe7") },
                    { new Guid("b9904e16-2e1f-4602-95cc-c9b237a2c193"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5755), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5757), false, new Guid("de7b471b-af6c-4155-9bf5-a4d964678bc6") },
                    { new Guid("b9f1459d-e48f-4a0e-98e6-34f6d2b71e8b"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6194), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6195), false, new Guid("5557f670-3330-4144-9ea1-f47c2a45ff7f") },
                    { new Guid("ba7e2183-81d8-4666-842d-fe10d3df25d0"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6074), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6076), false, new Guid("7b4381d7-3ba9-4fbc-bff3-e7f54dbc8625") },
                    { new Guid("bea0aa31-4927-4043-95e5-2d6637be4c0e"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5981), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5982), false, new Guid("7816c680-1d79-40e4-95e6-3f727473b352") },
                    { new Guid("bf970f67-737a-4c5b-a9a6-d3bbc31c3615"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5606), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5607), false, new Guid("72dbc22c-72c9-49f5-9f0c-5d55e1754220") },
                    { new Guid("c0d90476-cd60-4b26-8736-271cf635ce4f"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5742), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5744), false, new Guid("3a97972b-976e-4787-b628-a15dc2e3bc32") },
                    { new Guid("c68b3d46-6091-4221-b247-1797fbde64be"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6271), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6273), false, new Guid("2e7c3a53-7a0c-42e7-8ed0-bf8625762e7f") },
                    { new Guid("cac08be4-f887-4eff-b6d4-fb3dde3c4049"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6294), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6296), false, new Guid("e02f6c8d-0e0b-43f8-a6f4-148a3c46ed3c") },
                    { new Guid("cad3ffbd-8bef-495f-b749-2951b5a7366a"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5857), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5859), false, new Guid("d60a9162-4fc2-4265-8d12-291ab344432f") },
                    { new Guid("cc649f35-703a-4b7e-a85f-c1564da7bf3b"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5708), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5710), false, new Guid("ff7e50ef-778b-4d22-be3c-b9afbf7b93c9") },
                    { new Guid("d1132814-d5b1-445a-829b-3688ec9f5126"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6066), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6068), false, new Guid("a86dab2e-5f86-486d-85dc-35298f75834b") },
                    { new Guid("d16f2a93-435e-4aae-886f-a7c5284056ee"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6177), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6178), false, new Guid("3034c1dc-458e-4a63-91a1-5f4162d50cc6") },
                    { new Guid("d43287f0-9bc5-4c38-a4a1-3c5e239935bb"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5894), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5895), false, new Guid("053bc7a9-8c52-4938-85a1-47c5f1ac1944") },
                    { new Guid("d5417158-ed2a-4ebb-b4a7-fed8425a0517"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6045), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6046), false, new Guid("301d19f2-1f58-460e-b4b4-66c7a438ba62") },
                    { new Guid("d829b328-e490-42dc-b3dc-b3508bb92b1d"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6311), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6312), false, new Guid("6b6c3be7-2856-4e32-a4bd-7b07390ce9a9") },
                    { new Guid("d8ae3daa-077e-4463-9412-fc6d34d6e10c"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6131), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6133), false, new Guid("a642f3c5-4e96-4131-ad5c-52f5a6594e5f") },
                    { new Guid("d9acaf31-4b8b-4193-9311-09ba35eecfe3"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5801), false, new Guid("2790301b-54b0-4360-847c-d370851a5146") },
                    { new Guid("dcbfa8f2-f1fe-418d-97e5-6811371030b6"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6321), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6323), false, new Guid("e2e38434-2d6a-4040-a6e3-d0f2934c9597") },
                    { new Guid("dce75302-c68c-4d86-9c91-351c09b089f8"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6015), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6017), false, new Guid("c2dd9171-3128-4275-bc0c-04daba85c5c0") },
                    { new Guid("dd0cffca-21a7-4a10-89e0-635b759effd3"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5879), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5880), false, new Guid("a17c4417-61a2-4932-b988-0cbffae49940") },
                    { new Guid("dd4199ca-9ff2-4f99-b75a-ed7829e94f24"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5697), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5699), false, new Guid("8816a160-9b0b-453b-a564-c5f5a7f179d8") },
                    { new Guid("de987078-df6f-40c6-a67c-b1e47719d9d1"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6307), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6308), false, new Guid("a86dab2e-5f86-486d-85dc-35298f75834b") },
                    { new Guid("dfe33587-7ced-4678-8689-905efd4257fc"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6244), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6246), false, new Guid("de7b471b-af6c-4155-9bf5-a4d964678bc6") },
                    { new Guid("e0919c24-9b91-419b-bf3e-ac8624d142c1"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5704), false, new Guid("c2d3b691-4962-4bba-86ce-edb3b030dd8d") },
                    { new Guid("e1228ddd-03b8-432b-aed3-ba0d0f62c034"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6255), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6256), false, new Guid("c2dd9171-3128-4275-bc0c-04daba85c5c0") },
                    { new Guid("e256d0c4-e24b-46e3-9032-d3124f17250d"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5692), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5694), false, new Guid("9ed633ed-942f-4be6-a627-394e0dcc0fa0") },
                    { new Guid("e4d3c69e-8064-4861-aac0-afd9db398341"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6343), false, new Guid("f7cd5a3f-15fe-441a-9599-3d76c11a73af") },
                    { new Guid("e7a26276-1940-48f4-821b-521c97fcc25b"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5871), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5872), false, new Guid("f7cd5a3f-15fe-441a-9599-3d76c11a73af") },
                    { new Guid("e9620d80-9920-4baf-b599-a2cbf5363e22"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5597), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5599), false, new Guid("a17c4417-61a2-4932-b988-0cbffae49940") },
                    { new Guid("e9e6311a-861a-4d4e-8eeb-b5748d2034c5"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5683), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5684), false, new Guid("5557f670-3330-4144-9ea1-f47c2a45ff7f") },
                    { new Guid("f1306d6e-a6a1-4dc8-b57b-1984d554d03e"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5987), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5989), false, new Guid("ebca884c-abef-4d3a-b2d6-b6ef87c94af8") },
                    { new Guid("f28ee974-f1bc-477a-8819-a9d1c8440c0d"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5751), false, new Guid("2f6585bc-dd32-4303-a640-1fc0c874a66f") },
                    { new Guid("f363c29f-2a5f-4065-b6d8-c5b1c4ff22f4"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5617), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5618), false, new Guid("053bc7a9-8c52-4938-85a1-47c5f1ac1944") },
                    { new Guid("f3798919-d938-440f-9f7a-b51a952d43db"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5938), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5940), false, new Guid("1436af82-a8c3-46f5-938c-e3ef7729e9d5") },
                    { new Guid("f454465b-ddfb-4f95-b4e6-006f8ed5ab54"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6165), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6166), false, new Guid("2c0f2ba0-3b52-4381-b6cb-dd1fa5b5ebe7") },
                    { new Guid("f4ee01b0-4a42-4422-a5f4-0b670c47cc82"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5805), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5807), false, new Guid("301d19f2-1f58-460e-b4b4-66c7a438ba62") },
                    { new Guid("f5cfba88-7498-46a5-b5d1-13fc9edd9cc7"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6303), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6304), false, new Guid("639cf491-c4c1-4b80-b1f0-014e7e6bf22e") },
                    { new Guid("f8cf0ca1-6f7b-4aad-a8f4-19a8aa3480cb"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6173), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6174), false, new Guid("ed927e79-fdb1-4a57-9bcc-7bcaebe43154") },
                    { new Guid("f94535be-cf54-4472-b077-0e6dc0792dc8"), new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5961), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5962), false, new Guid("8816a160-9b0b-453b-a564-c5f5a7f179d8") },
                    { new Guid("ff4b7dab-c7b5-40b4-b47e-93d247ddd5b2"), new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5622), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5624), false, new Guid("bafdbb35-ab1b-42d5-a127-2757ff31b3aa") },
                    { new Guid("ffa70d25-44c9-496b-b751-2c066b9874ec"), new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6139), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(6141), false, new Guid("72dbc22c-72c9-49f5-9f0c-5d55e1754220") }
                });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "Id", "ClientId", "ClosingDate", "DateCreated", "DateUpdated", "OpeningDate", "Title", "WinnersDrawn" },
                values: new object[,]
                {
                    { new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"), new Guid("6d6e860a-d170-4175-8136-1ab4c313ca21"), new DateTime(2023, 4, 9, 19, 12, 10, 831, DateTimeKind.Local).AddTicks(3818), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3820), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3821), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3817), "Share the love", false },
                    { new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"), new Guid("4e65bbb3-64ad-4006-9a1b-fd1769f28754"), new DateTime(2023, 4, 9, 19, 12, 10, 831, DateTimeKind.Local).AddTicks(3812), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3813), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3815), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3810), "Sampling with capital xtra", false },
                    { new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"), new Guid("1a5ab7b3-433a-4ced-a0d1-eeb27f711435"), new DateTime(2023, 4, 9, 19, 12, 10, 831, DateTimeKind.Local).AddTicks(3803), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3807), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3808), new DateTime(2023, 4, 9, 19, 11, 10, 831, DateTimeKind.Local).AddTicks(3802), "Product launch instant win", false }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Country", "County", "DateCreated", "DateUpdated", "Email", "Forename", "Surname", "Telephone", "Town" },
                values: new object[,]
                {
                    { new Guid("053bc7a9-8c52-4938-85a1-47c5f1ac1944"), "Scotland", "Highland", new DateTime(2023, 4, 9, 19, 11, 10, 841, DateTimeKind.Local).AddTicks(7074), new DateTime(2023, 4, 9, 19, 11, 10, 841, DateTimeKind.Local).AddTicks(7119), "brailee.crutcher@outlook.com", "Brailee", "Crutcher", "0717282731", "Kingussie" },
                    { new Guid("0afd8506-babc-49ec-8614-4f62ba4071d5"), "Scotland", "Argyll and Bute", new DateTime(2023, 4, 9, 19, 11, 10, 883, DateTimeKind.Local).AddTicks(9190), new DateTime(2023, 4, 9, 19, 11, 10, 883, DateTimeKind.Local).AddTicks(9212), "aliana.post@yahoo.co.uk", "Aliana", "Post", "0805723551", "Lochgilphead" },
                    { new Guid("1436af82-a8c3-46f5-938c-e3ef7729e9d5"), "Scotland", "Aberdeenshire", new DateTime(2023, 4, 9, 19, 11, 10, 850, DateTimeKind.Local).AddTicks(4226), new DateTime(2023, 4, 9, 19, 11, 10, 850, DateTimeKind.Local).AddTicks(4239), "cameron.gray@hotmail.com", "Cameron", "Gray", "0704379474", "Banff" },
                    { new Guid("1f47891f-dfde-40ff-a1ee-d2d223a001f5"), "Scotland", "Highland", new DateTime(2023, 4, 9, 19, 11, 10, 874, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 4, 9, 19, 11, 10, 874, DateTimeKind.Local).AddTicks(8565), "zaki.massa@gmail.com", "Zaki", "Massa", "0921373721", "Kingussie" },
                    { new Guid("2790301b-54b0-4360-847c-d370851a5146"), "England", "County Durham", new DateTime(2023, 4, 9, 19, 11, 10, 880, DateTimeKind.Local).AddTicks(426), new DateTime(2023, 4, 9, 19, 11, 10, 880, DateTimeKind.Local).AddTicks(441), "spencer.michaels@aol.com", "Spencer", "Michaels", "0737503420", "Durham" },
                    { new Guid("2ababd28-3d1d-49a5-a91c-f68c42c809c5"), "Scotland", "Shetland Islands", new DateTime(2023, 4, 9, 19, 11, 10, 892, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 4, 9, 19, 11, 10, 892, DateTimeKind.Local).AddTicks(7783), "kairos.whisenant@hotmail.co.uk", "Kairos", "Whisenant", "0905780360", "Lerwick" },
                    { new Guid("2c0f2ba0-3b52-4381-b6cb-dd1fa5b5ebe7"), "Scotland", "Aberdeenshire", new DateTime(2023, 4, 9, 19, 11, 10, 845, DateTimeKind.Local).AddTicks(5790), new DateTime(2023, 4, 9, 19, 11, 10, 845, DateTimeKind.Local).AddTicks(5804), "bransen.kellner@outlook.com", "Bransen", "Kellner", "0823475962", "Inverurie" },
                    { new Guid("2e7c3a53-7a0c-42e7-8ed0-bf8625762e7f"), "Scotland", "Stirling", new DateTime(2023, 4, 9, 19, 11, 10, 878, DateTimeKind.Local).AddTicks(1392), new DateTime(2023, 4, 9, 19, 11, 10, 878, DateTimeKind.Local).AddTicks(1408), "amaryllis.binkley@yahoo.com", "Amaryllis", "Binkley", "0900103350", "Stirling" },
                    { new Guid("2f6585bc-dd32-4303-a640-1fc0c874a66f"), "England", "Leicestershire", new DateTime(2023, 4, 9, 19, 11, 10, 870, DateTimeKind.Local).AddTicks(5000), new DateTime(2023, 4, 9, 19, 11, 10, 870, DateTimeKind.Local).AddTicks(5013), "joscelyn.northrop@aol.com", "Joscelyn", "Northrop", "0708027328", "Loughborough" },
                    { new Guid("301d19f2-1f58-460e-b4b4-66c7a438ba62"), "Scotland", "Aberdeenshire", new DateTime(2023, 4, 9, 19, 11, 10, 881, DateTimeKind.Local).AddTicks(148), new DateTime(2023, 4, 9, 19, 11, 10, 881, DateTimeKind.Local).AddTicks(161), "menachem.arteaga@hotmail.com", "Menachem", "Arteaga", "0737985939", "Banchory" },
                    { new Guid("3034c1dc-458e-4a63-91a1-5f4162d50cc6"), "England", "Gloucestershire", new DateTime(2023, 4, 9, 19, 11, 10, 848, DateTimeKind.Local).AddTicks(4979), new DateTime(2023, 4, 9, 19, 11, 10, 848, DateTimeKind.Local).AddTicks(4993), "hiro.pearl@aol.com", "Hiro", "Pearl", "0769633440", "Cheltenham" },
                    { new Guid("39c6cabf-68ce-464f-94c1-eba1e212a012"), "Scotland", "Angus", new DateTime(2023, 4, 9, 19, 11, 10, 849, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 4, 9, 19, 11, 10, 849, DateTimeKind.Local).AddTicks(4566), "louisa.quiroz@outlook.com", "Louisa", "Quiroz", "0764098386", "Brechin" },
                    { new Guid("3a97972b-976e-4787-b628-a15dc2e3bc32"), "Scotland", "Argyll and Bute", new DateTime(2023, 4, 9, 19, 11, 10, 869, DateTimeKind.Local).AddTicks(5381), new DateTime(2023, 4, 9, 19, 11, 10, 869, DateTimeKind.Local).AddTicks(5422), "aoife.deloach@outlook.com", "Aoife", "Deloach", "0948755595", "Cairndow" },
                    { new Guid("42f91b0f-c72c-4ded-a03d-974f5aa31c70"), "Scotland", "Moray", new DateTime(2023, 4, 9, 19, 11, 10, 875, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 4, 9, 19, 11, 10, 875, DateTimeKind.Local).AddTicks(8810), "edy.boaz@hotmail.com", "Edy", "Boaz", "0825213884", "Keith" },
                    { new Guid("5557f670-3330-4144-9ea1-f47c2a45ff7f"), "England", "Somerset", new DateTime(2023, 4, 9, 19, 11, 10, 852, DateTimeKind.Local).AddTicks(3193), new DateTime(2023, 4, 9, 19, 11, 10, 852, DateTimeKind.Local).AddTicks(3205), "timur.thrower@hotmail.co.uk", "Timur", "Thrower", "0788142030", "Taunton" },
                    { new Guid("59781431-969d-4057-89aa-103e010c23c6"), "Scotland", "City of Edinburgh", new DateTime(2023, 4, 9, 19, 11, 10, 891, DateTimeKind.Local).AddTicks(8082), new DateTime(2023, 4, 9, 19, 11, 10, 891, DateTimeKind.Local).AddTicks(8094), "arie.staggs@hotmail.com", "Arie", "Staggs", "0816009737", "Edinburgh" },
                    { new Guid("5e94d73c-6924-4882-a2c4-6fb47659fa70"), "England", "Cornwall", new DateTime(2023, 4, 9, 19, 11, 10, 879, DateTimeKind.Local).AddTicks(987), new DateTime(2023, 4, 9, 19, 11, 10, 879, DateTimeKind.Local).AddTicks(1002), "geremiah.marvel@hotmail.com", "Geremiah", "Marvel", "0895856078", "St Austell" },
                    { new Guid("639cf491-c4c1-4b80-b1f0-014e7e6bf22e"), "Scotland", "Highland", new DateTime(2023, 4, 9, 19, 11, 10, 884, DateTimeKind.Local).AddTicks(9346), new DateTime(2023, 4, 9, 19, 11, 10, 884, DateTimeKind.Local).AddTicks(9362), "margaux.wilde@yahoo.com", "Margaux", "Wilde", "0786428555", "Nairn" },
                    { new Guid("6b6c3be7-2856-4e32-a4bd-7b07390ce9a9"), "Scotland", "Dumfries and Galloway", new DateTime(2023, 4, 9, 19, 11, 10, 886, DateTimeKind.Local).AddTicks(9009), new DateTime(2023, 4, 9, 19, 11, 10, 886, DateTimeKind.Local).AddTicks(9021), "marcos.acevedo@outlook.com", "Marcos", "Acevedo", "0706077992", "Dumfries" },
                    { new Guid("7169de8d-f64b-4e78-afa3-56d02ed5e88a"), "England", "Hampshire", new DateTime(2023, 4, 9, 19, 11, 10, 840, DateTimeKind.Local).AddTicks(5774), new DateTime(2023, 4, 9, 19, 11, 10, 840, DateTimeKind.Local).AddTicks(5799), "emerald.conn@yahoo.co.uk", "Emerald", "Conn", "0816539045", "Southampton" },
                    { new Guid("71e8c13a-8f94-49ca-a5cd-b28b8646b178"), "Scotland", "Dumfries and Galloway", new DateTime(2023, 4, 9, 19, 11, 10, 889, DateTimeKind.Local).AddTicks(9409), new DateTime(2023, 4, 9, 19, 11, 10, 889, DateTimeKind.Local).AddTicks(9421), "derik.record@aol.com", "Derik", "Record", "0914320737", "Castle Douglas" },
                    { new Guid("72dbc22c-72c9-49f5-9f0c-5d55e1754220"), "England", "Kent", new DateTime(2023, 4, 9, 19, 11, 10, 839, DateTimeKind.Local).AddTicks(3462), new DateTime(2023, 4, 9, 19, 11, 10, 839, DateTimeKind.Local).AddTicks(3512), "asael.haight@outlook.com", "Asael", "Haight", "0726229691", "Tunbridge Wells" },
                    { new Guid("7816c680-1d79-40e4-95e6-3f727473b352"), "Scotland", "Fife", new DateTime(2023, 4, 9, 19, 11, 10, 858, DateTimeKind.Local).AddTicks(3577), new DateTime(2023, 4, 9, 19, 11, 10, 858, DateTimeKind.Local).AddTicks(3594), "aoife.deloach@yahoo.com", "Aoife", "Deloach", "0915677464", "St Andrews" },
                    { new Guid("7b4381d7-3ba9-4fbc-bff3-e7f54dbc8625"), "England", "County Durham", new DateTime(2023, 4, 9, 19, 11, 10, 887, DateTimeKind.Local).AddTicks(9568), new DateTime(2023, 4, 9, 19, 11, 10, 887, DateTimeKind.Local).AddTicks(9583), "yelena.kight@aol.com", "Yelena", "Kight", "0724217712", "Stockton-on-Tees" },
                    { new Guid("8816a160-9b0b-453b-a564-c5f5a7f179d8"), "Scotland", "Dumfries and Galloway", new DateTime(2023, 4, 9, 19, 11, 10, 854, DateTimeKind.Local).AddTicks(2368), new DateTime(2023, 4, 9, 19, 11, 10, 854, DateTimeKind.Local).AddTicks(2382), "nuha.hartline@gmail.com", "Nuha", "Hartline", "0988730330", "Dumfries" },
                    { new Guid("9007f20e-2dbb-4a16-a133-7876f36e772d"), "Scotland", "Argyll and Bute", new DateTime(2023, 4, 9, 19, 11, 10, 843, DateTimeKind.Local).AddTicks(5984), new DateTime(2023, 4, 9, 19, 11, 10, 843, DateTimeKind.Local).AddTicks(5997), "ashur.mckean@outlook.com", "Ashur", "Mckean", "0823394461", "Oban" },
                    { new Guid("9b59efdd-c1ef-4c90-87c2-379a1bb6da7a"), "England", "County Durham", new DateTime(2023, 4, 9, 19, 11, 10, 895, DateTimeKind.Local).AddTicks(5917), new DateTime(2023, 4, 9, 19, 11, 10, 895, DateTimeKind.Local).AddTicks(5929), "katai.ambrosio@hotmail.co.uk", "Katai", "Ambrosio", "0922138752", "Stockton-on-Tees" },
                    { new Guid("9ed633ed-942f-4be6-a627-394e0dcc0fa0"), "Scotland", "Argyll and Bute", new DateTime(2023, 4, 9, 19, 11, 10, 853, DateTimeKind.Local).AddTicks(2443), new DateTime(2023, 4, 9, 19, 11, 10, 853, DateTimeKind.Local).AddTicks(2455), "lamya.metzler@yahoo.co.uk", "Lamya", "Metzler", "0981565257", "Isle of Mull" },
                    { new Guid("a17c4417-61a2-4932-b988-0cbffae49940"), "England", "West Yorkshire", new DateTime(2023, 4, 9, 19, 11, 10, 832, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 4, 9, 19, 11, 10, 832, DateTimeKind.Local).AddTicks(7786), "brelynn.shriver@yahoo.com", "Brelynn", "Shriver", "0896519456", "Leeds" },
                    { new Guid("a642f3c5-4e96-4131-ad5c-52f5a6594e5f"), "Scotland", "Highland", new DateTime(2023, 4, 9, 19, 11, 10, 894, DateTimeKind.Local).AddTicks(6616), new DateTime(2023, 4, 9, 19, 11, 10, 894, DateTimeKind.Local).AddTicks(6628), "astrid.messer@aol.com", "Astrid", "Messer", "0845907031", "Nairn" },
                    { new Guid("a86dab2e-5f86-486d-85dc-35298f75834b"), "England", "Surrey", new DateTime(2023, 4, 9, 19, 11, 10, 885, DateTimeKind.Local).AddTicks(9564), new DateTime(2023, 4, 9, 19, 11, 10, 885, DateTimeKind.Local).AddTicks(9578), "kara.shea@aol.com", "Kara", "Shea", "0899048060", "Guildford" },
                    { new Guid("ae214892-1bb5-441c-a03a-a27f0210bcd9"), "Scotland", "Argyll and Bute", new DateTime(2023, 4, 9, 19, 11, 10, 868, DateTimeKind.Local).AddTicks(4109), new DateTime(2023, 4, 9, 19, 11, 10, 868, DateTimeKind.Local).AddTicks(4164), "cameron.gray@hotmail.com", "Cameron", "Gray", "0844966074", "Oban" },
                    { new Guid("b20ccb2d-205a-42ef-94c5-6e80a47b5d8e"), "Scotland", "Highland", new DateTime(2023, 4, 9, 19, 11, 10, 881, DateTimeKind.Local).AddTicks(9565), new DateTime(2023, 4, 9, 19, 11, 10, 881, DateTimeKind.Local).AddTicks(9578), "laina.quarles@aol.com", "Laina", "Quarles", "0985510865", "Glenfinnan" },
                    { new Guid("b2d249b5-4215-4aa7-88f6-b3831eff5f4d"), "England", "North Yorkshire", new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5542), new DateTime(2023, 4, 9, 19, 11, 10, 896, DateTimeKind.Local).AddTicks(5556), "tori.vickers@yahoo.com", "Tori", "Vickers", "0819524336", "York" },
                    { new Guid("bafdbb35-ab1b-42d5-a127-2757ff31b3aa"), "England", "Devon", new DateTime(2023, 4, 9, 19, 11, 10, 842, DateTimeKind.Local).AddTicks(6716), new DateTime(2023, 4, 9, 19, 11, 10, 842, DateTimeKind.Local).AddTicks(6728), "jolina.pelfrey@gmail.com", "Jolina", "Pelfrey", "0877734047", "Exeter" },
                    { new Guid("c0ad6371-94c1-4556-bc4a-c20b83cf13de"), "England", "East Sussex", new DateTime(2023, 4, 9, 19, 11, 10, 851, DateTimeKind.Local).AddTicks(3809), new DateTime(2023, 4, 9, 19, 11, 10, 851, DateTimeKind.Local).AddTicks(3822), "clinton.wilburn@aol.com", "Clinton", "Wilburn", "0803588651", "Hastings" },
                    { new Guid("c2d3b691-4962-4bba-86ce-edb3b030dd8d"), "Scotland", "South Ayrshire", new DateTime(2023, 4, 9, 19, 11, 10, 855, DateTimeKind.Local).AddTicks(2190), new DateTime(2023, 4, 9, 19, 11, 10, 855, DateTimeKind.Local).AddTicks(2204), "laiah.oliveros@hotmail.co.uk", "Laiah", "Oliveros", "0941305368", "Ayr" },
                    { new Guid("c2dd9171-3128-4275-bc0c-04daba85c5c0"), "Scotland", "Stirling", new DateTime(2023, 4, 9, 19, 11, 10, 873, DateTimeKind.Local).AddTicks(7801), new DateTime(2023, 4, 9, 19, 11, 10, 873, DateTimeKind.Local).AddTicks(7815), "kyra.benitez@yahoo.com", "Kyra", "Benitez", "0805560671", "Stirling" },
                    { new Guid("c40098f4-e3a1-4d2d-a19e-5d4801299c6f"), "Scotland", "Argyll and Bute", new DateTime(2023, 4, 9, 19, 11, 10, 857, DateTimeKind.Local).AddTicks(3576), new DateTime(2023, 4, 9, 19, 11, 10, 857, DateTimeKind.Local).AddTicks(3594), "damarion.grier@yahoo.com", "Damarion", "Grier", "0793174362", "Cairndow" },
                    { new Guid("d0c2ff00-0264-4490-82f5-0871d5355361"), "England", "Devon", new DateTime(2023, 4, 9, 19, 11, 10, 846, DateTimeKind.Local).AddTicks(5473), new DateTime(2023, 4, 9, 19, 11, 10, 846, DateTimeKind.Local).AddTicks(5488), "rico.almanza@hotmail.co.uk", "Rico", "Almanza", "0876948248", "Devonport" },
                    { new Guid("d60a9162-4fc2-4265-8d12-291ab344432f"), "England", "East Sussex", new DateTime(2023, 4, 9, 19, 11, 10, 890, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 4, 9, 19, 11, 10, 890, DateTimeKind.Local).AddTicks(8643), "vedant.posada@hotmail.com", "Vedant", "Posada", "0992682812", "Brighton" },
                    { new Guid("d9465ba6-8a98-44ee-89af-b8e53c53ee2e"), "Scotland", "Perth and Kinross", new DateTime(2023, 4, 9, 19, 11, 10, 872, DateTimeKind.Local).AddTicks(8392), new DateTime(2023, 4, 9, 19, 11, 10, 872, DateTimeKind.Local).AddTicks(8416), "quenton.wilton@gmail.com", "Quenton", "Wilton", "0859329734", "Pitlochry" },
                    { new Guid("de7b471b-af6c-4155-9bf5-a4d964678bc6"), "Scotland", "Glasgow City", new DateTime(2023, 4, 9, 19, 11, 10, 871, DateTimeKind.Local).AddTicks(8017), new DateTime(2023, 4, 9, 19, 11, 10, 871, DateTimeKind.Local).AddTicks(8065), "juno.pagano@yahoo.co.uk", "Juno", "Pagano", "0799659773", "Glasgow" },
                    { new Guid("dfca5d02-0c40-46ee-a674-89543d1b6f2e"), "England", "Greater Manchester", new DateTime(2023, 4, 9, 19, 11, 10, 844, DateTimeKind.Local).AddTicks(5933), new DateTime(2023, 4, 9, 19, 11, 10, 844, DateTimeKind.Local).AddTicks(5948), "brixton.ruffin@outlook.com", "Brixton", "Ruffin", "0879541693", "Wigan" },
                    { new Guid("e02f6c8d-0e0b-43f8-a6f4-148a3c46ed3c"), "Scotland", "Highland", new DateTime(2023, 4, 9, 19, 11, 10, 882, DateTimeKind.Local).AddTicks(8869), new DateTime(2023, 4, 9, 19, 11, 10, 882, DateTimeKind.Local).AddTicks(8882), "etty.valero@yahoo.com", "Etty", "Valero", "0922554093", "Isle of Skye" },
                    { new Guid("e2e38434-2d6a-4040-a6e3-d0f2934c9597"), "Scotland", "Moray", new DateTime(2023, 4, 9, 19, 11, 10, 888, DateTimeKind.Local).AddTicks(9812), new DateTime(2023, 4, 9, 19, 11, 10, 888, DateTimeKind.Local).AddTicks(9827), "spencer.michaels@yahoo.co.uk", "Spencer", "Michaels", "0811445289", "Elgin" },
                    { new Guid("ea599c07-3902-47fd-8822-6878c8aa04b4"), "England", "Norfolk", new DateTime(2023, 4, 9, 19, 11, 10, 867, DateTimeKind.Local).AddTicks(1075), new DateTime(2023, 4, 9, 19, 11, 10, 867, DateTimeKind.Local).AddTicks(1162), "emerald.conn@outlook.com", "Emerald", "Conn", "0903808964", "Great Yarmouth" },
                    { new Guid("ebca884c-abef-4d3a-b2d6-b6ef87c94af8"), "England", "City of Bristol", new DateTime(2023, 4, 9, 19, 11, 10, 859, DateTimeKind.Local).AddTicks(3087), new DateTime(2023, 4, 9, 19, 11, 10, 859, DateTimeKind.Local).AddTicks(3100), "darek.jumper@yahoo.com", "Darek", "Jumper", "0847836624", "Bristol" },
                    { new Guid("ed927e79-fdb1-4a57-9bcc-7bcaebe43154"), "Scotland", "Highland", new DateTime(2023, 4, 9, 19, 11, 10, 847, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 4, 9, 19, 11, 10, 847, DateTimeKind.Local).AddTicks(5119), "jahsir.dressler@aol.com", "Jahsir", "Dressler", "0841307934", "Isle of Skye" },
                    { new Guid("f7cd5a3f-15fe-441a-9599-3d76c11a73af"), "England", "Lincolnshire", new DateTime(2023, 4, 9, 19, 11, 10, 893, DateTimeKind.Local).AddTicks(7239), new DateTime(2023, 4, 9, 19, 11, 10, 893, DateTimeKind.Local).AddTicks(7251), "rain.steinman@yahoo.co.uk", "Rain", "Steinman", "0829031329", "Scunthorpe" },
                    { new Guid("f7dac28c-5c83-4925-b334-c7db7680c988"), "England", "Northumberland", new DateTime(2023, 4, 9, 19, 11, 10, 877, DateTimeKind.Local).AddTicks(159), new DateTime(2023, 4, 9, 19, 11, 10, 877, DateTimeKind.Local).AddTicks(201), "clarabelle.candelario@outlook.com", "Clarabelle", "Candelario", "0968166995", "Alnwick" },
                    { new Guid("ff7e50ef-778b-4d22-be3c-b9afbf7b93c9"), "Scotland", "South Ayrshire", new DateTime(2023, 4, 9, 19, 11, 10, 856, DateTimeKind.Local).AddTicks(3186), new DateTime(2023, 4, 9, 19, 11, 10, 856, DateTimeKind.Local).AddTicks(3234), "vedant.posada@gmail.com", "Vedant", "Posada", "0936697952", "Troon" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1a5ab7b3-433a-4ced-a0d1-eeb27f711435"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4e65bbb3-64ad-4006-9a1b-fd1769f28754"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6d6e860a-d170-4175-8136-1ab4c313ca21"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("016ee2dd-18b5-480e-9dcb-d8f3397b718e"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("01dfddac-5a09-4c36-81f7-7bbe2cd95f2c"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("04f83094-41e0-4f17-8756-ba202fea3cff"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("0524e56f-3872-44a3-a677-1f384e2a0805"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("05ad49d9-04db-4085-8e68-5b2ab5abaae1"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("061770b3-cc63-4ea7-8b91-45b129a2e1f1"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("07282068-98e2-4e42-9561-aca2a7a14f9a"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("084c330c-8d3d-4d44-8385-e80525b9c789"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("0858102e-2e2e-468d-8b74-3a4582037601"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("085bdd43-8d55-482a-8c0b-7afe8b5c1f09"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("08df996e-9c4c-4a8b-a8e7-c67157ddd06e"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("0b78e1f7-6663-4400-a429-48b97b9a8073"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("15176e22-d90e-4da2-a5d1-d906b791cfd4"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("15204dc7-8434-41b7-bce2-f4db4d639290"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("1640e153-0f80-4fca-aafb-fc39a4e32d26"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("19f9ab7d-232d-4ace-ae18-ea5460e5153a"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("1a4a7259-7270-4cef-9772-517e29d0e1c8"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("1cc00b86-bb96-4558-90df-bbb7f5e4c623"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("1fd295d6-7104-421e-adbc-3bd92b153afd"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("2aea7db2-eb1e-48b3-97a8-f31b5cb3c117"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("2dfa99a6-3c29-416e-a771-3354c6f66926"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("2e819cb6-8d14-4da1-8ccc-fb27bfd575fe"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("2ed017e0-8f02-4323-8461-49ef78b6f39e"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("353b116d-f009-4b2f-8088-77d761836876"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("362e4191-5bc6-47de-8afa-bef38dbe01f7"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("36a73a1e-5c6c-41a0-8349-8256dbffc5ad"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("38845614-ae6c-46b9-9860-ed1b3ab78603"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("40caec20-445a-4ce7-b62d-1f3b9ff8f92a"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("41cc5661-622c-4d9a-9134-edf3f1cb8706"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("430e5fd0-109b-4643-8df2-07bb7000c29b"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("43f60552-3e29-4c6b-822d-51d36ce0f352"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("49c26d66-e5cc-4b6e-b260-b07bd900d5db"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("4a6a39e7-0c2f-4061-bdf6-95e9816e3fac"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("530319cf-f2cf-4e65-bf31-0bf77e4e5b77"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("54bcf09d-4b4e-402d-bfe0-af24d03ce22e"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("559cd6b7-5ca5-4f1d-9b35-70f0e00907e4"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("55df1479-4976-415c-bc55-5d8dbb987fa9"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("5646850b-3b0f-43a8-b6ad-fa38b9cc46a2"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("57e9adba-c95e-499b-995b-896c2336ddfe"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("5838843b-7c05-4538-8451-8338a6a7b9dd"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("5964add5-23bd-4805-a14c-5d394188abc5"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("5c0abc9a-0e8a-45b7-8680-972bc4673b36"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("5fc6693d-feef-4be7-a2e7-12091000dd43"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("5fd327a3-6de8-482a-9234-19bd0f0b286d"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("5ff8d2c7-3ac5-4b52-927a-8ab5d670f4e9"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("6252c66b-3af1-428e-99a9-7d2ca92a4052"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("62b07d7a-d695-4ffb-bf6f-d09c4a05cbef"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("63be27a7-2a4f-41b1-9607-d343e9dd78b0"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("64114694-e376-4d3f-a722-7a9a90860163"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("64c8a9bd-a5a3-4d7f-889c-3042dccd5953"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("67a740e3-926f-47f0-bb93-2dcf55a95b5d"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("685e8e7d-f80c-4dd6-aeab-3b6fce62f82a"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("6986a24e-02ff-4d68-b9eb-85df6fc2134f"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("6ac81072-046e-47d4-8f5a-82edf6adf32e"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("6bc18db7-50e7-4bb5-9875-79a46a491942"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("6deefbb6-28e7-4047-ae71-fdb186f6f3f7"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("6e13d48f-a4bb-4485-a01e-25523326f55a"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("6e542789-bc90-4381-ab2a-4d3df67d5864"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("6ee0f001-b60a-49be-a550-774395441ed7"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("6ee81f2d-1ecb-421e-98c4-c020ac0b9b5c"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("70934c39-8627-488f-8baa-6fc940d3feaf"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("712d72db-bc3f-40e2-adbf-b34876a449a5"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("71e0323a-abfa-409f-b47f-ef231151dd77"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("7494030d-5bbc-4214-b346-9db96b4a1464"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("77aaa49a-fd7c-4ce0-844e-959066cc530d"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("78004f6e-bf21-430b-b958-e5401d1cdac6"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("79e8060f-f977-4001-be3c-f62fd26ecbab"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("7b6d6802-833b-4c13-8beb-34615ce3ae8d"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("7cf2acd3-7322-4b9b-b734-fb7f8b9583cd"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("7cfafca1-d821-4ea6-af81-04da8a277762"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("7d71da35-29f7-406e-8e2d-e03ae1b0eb27"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("7d8bc2ce-b1c4-4065-8b1a-76bc96737ca7"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("832e5fae-32a9-43b9-8e3d-a90beedfc3e3"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("84775e0a-9fdd-4986-9ef8-623b4fab562e"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("84aee634-58f1-43a2-a8eb-cdbeeb29304d"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("8575df94-d0da-4165-8188-cb4d55bcd01c"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("8786fb1c-4fe3-40cc-80b1-22da7a9b18b9"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("8a8d7a9d-32c7-4701-a58f-d7b9f958b670"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("8b67ce6b-b65a-4d4e-87d5-145cb2dfa485"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("8da0911b-3735-495d-ab12-d8fb758b1932"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("8e19c30f-eb45-42c0-a586-6f6716d0736b"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("8f6c8061-0a89-4b41-8aa2-7bf19787ade3"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("902ae2ee-9e2a-47a0-ae55-b670a9e01032"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("92b537ed-f9e1-481b-85c1-aa9e3a58fca5"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("98d18f16-312c-4fcc-be3c-95466f2090ca"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("99124208-c052-4842-aa23-546738e3d0e2"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("999576ff-ff5e-4a3b-b4f0-265a4ee3cf92"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("9a3ea4bc-aa2b-438f-9671-00831ce798b0"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("9bb79d6b-cfd4-4e1c-ab75-6d72e24af0e6"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("9d4b07ff-3f22-469c-b957-8832fc840bd1"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("9e4fa869-de50-4e37-87a5-92e57e972b78"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("9f75955c-4cf6-48da-84cb-05a0795bc201"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("9fe22cfa-e6a0-4f82-a9a2-9c5f4fe6b077"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("a1897d44-e4fb-428b-94ef-22f98043da5b"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("a2463818-f11c-42b0-a10b-cffc6ee173b1"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("a2a99e80-1ca6-4731-a909-cde095d76c21"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("a2e740a4-502b-4dec-8334-5c1a2630ca60"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("a48510d1-2529-48c3-89c6-f87a7290f4b7"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("a48f62aa-a395-4ac9-b921-edf584fbd5b1"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("a4ecfd67-72a7-4d9c-916e-f40a1f21f1d2"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("a844842d-c405-4ef2-a410-4297f2ab3f4c"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("a87ed05b-69d7-4dbd-9f1d-36cd65323441"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("ac66205b-b241-4eba-847d-482304bc4ec7"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("ac6fb38d-8bc4-4788-9858-452f28998465"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("acbbaf5b-af15-4efc-9ce2-92bec91b59e7"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("ae74f964-4190-4632-9c83-ba2e0ceba3d6"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("b04c3165-e1b2-480c-bb50-e1d84a42c9f3"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("b2669a08-c09d-4a0c-a40d-8239ec393730"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("b8b431f7-7eb0-4ff5-a5b9-5091cd11cf79"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("b9904e16-2e1f-4602-95cc-c9b237a2c193"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("b9f1459d-e48f-4a0e-98e6-34f6d2b71e8b"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("ba7e2183-81d8-4666-842d-fe10d3df25d0"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("bea0aa31-4927-4043-95e5-2d6637be4c0e"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("bf970f67-737a-4c5b-a9a6-d3bbc31c3615"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("c0d90476-cd60-4b26-8736-271cf635ce4f"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("c68b3d46-6091-4221-b247-1797fbde64be"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("cac08be4-f887-4eff-b6d4-fb3dde3c4049"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("cad3ffbd-8bef-495f-b749-2951b5a7366a"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("cc649f35-703a-4b7e-a85f-c1564da7bf3b"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("d1132814-d5b1-445a-829b-3688ec9f5126"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("d16f2a93-435e-4aae-886f-a7c5284056ee"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("d43287f0-9bc5-4c38-a4a1-3c5e239935bb"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("d5417158-ed2a-4ebb-b4a7-fed8425a0517"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("d829b328-e490-42dc-b3dc-b3508bb92b1d"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("d8ae3daa-077e-4463-9412-fc6d34d6e10c"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("d9acaf31-4b8b-4193-9311-09ba35eecfe3"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("dcbfa8f2-f1fe-418d-97e5-6811371030b6"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("dce75302-c68c-4d86-9c91-351c09b089f8"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("dd0cffca-21a7-4a10-89e0-635b759effd3"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("dd4199ca-9ff2-4f99-b75a-ed7829e94f24"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("de987078-df6f-40c6-a67c-b1e47719d9d1"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("dfe33587-7ced-4678-8689-905efd4257fc"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("e0919c24-9b91-419b-bf3e-ac8624d142c1"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("e1228ddd-03b8-432b-aed3-ba0d0f62c034"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("e256d0c4-e24b-46e3-9032-d3124f17250d"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("e4d3c69e-8064-4861-aac0-afd9db398341"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("e7a26276-1940-48f4-821b-521c97fcc25b"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("e9620d80-9920-4baf-b599-a2cbf5363e22"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("e9e6311a-861a-4d4e-8eeb-b5748d2034c5"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("f1306d6e-a6a1-4dc8-b57b-1984d554d03e"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("f28ee974-f1bc-477a-8819-a9d1c8440c0d"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("f363c29f-2a5f-4065-b6d8-c5b1c4ff22f4"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("f3798919-d938-440f-9f7a-b51a952d43db"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("f454465b-ddfb-4f95-b4e6-006f8ed5ab54"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("f4ee01b0-4a42-4422-a5f4-0b670c47cc82"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("f5cfba88-7498-46a5-b5d1-13fc9edd9cc7"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("f8cf0ca1-6f7b-4aad-a8f4-19a8aa3480cb"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("f94535be-cf54-4472-b077-0e6dc0792dc8"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("ff4b7dab-c7b5-40b4-b47e-93d247ddd5b2"));

            migrationBuilder.DeleteData(
                table: "CompetitionEntries",
                keyColumn: "Id",
                keyValue: new Guid("ffa70d25-44c9-496b-b751-2c066b9874ec"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("52bf416d-51a9-4a09-b3c6-b40deb071e8f"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("b74ef9eb-d3b1-4094-a4c0-76777e0fe8bf"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("fe74eef1-9b2f-4142-ab86-d715fe4a0880"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("053bc7a9-8c52-4938-85a1-47c5f1ac1944"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("0afd8506-babc-49ec-8614-4f62ba4071d5"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("1436af82-a8c3-46f5-938c-e3ef7729e9d5"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("1f47891f-dfde-40ff-a1ee-d2d223a001f5"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("2790301b-54b0-4360-847c-d370851a5146"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("2ababd28-3d1d-49a5-a91c-f68c42c809c5"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("2c0f2ba0-3b52-4381-b6cb-dd1fa5b5ebe7"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("2e7c3a53-7a0c-42e7-8ed0-bf8625762e7f"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("2f6585bc-dd32-4303-a640-1fc0c874a66f"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("301d19f2-1f58-460e-b4b4-66c7a438ba62"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("3034c1dc-458e-4a63-91a1-5f4162d50cc6"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("39c6cabf-68ce-464f-94c1-eba1e212a012"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("3a97972b-976e-4787-b628-a15dc2e3bc32"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("42f91b0f-c72c-4ded-a03d-974f5aa31c70"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("5557f670-3330-4144-9ea1-f47c2a45ff7f"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("59781431-969d-4057-89aa-103e010c23c6"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("5e94d73c-6924-4882-a2c4-6fb47659fa70"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("639cf491-c4c1-4b80-b1f0-014e7e6bf22e"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("6b6c3be7-2856-4e32-a4bd-7b07390ce9a9"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("7169de8d-f64b-4e78-afa3-56d02ed5e88a"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("71e8c13a-8f94-49ca-a5cd-b28b8646b178"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("72dbc22c-72c9-49f5-9f0c-5d55e1754220"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("7816c680-1d79-40e4-95e6-3f727473b352"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("7b4381d7-3ba9-4fbc-bff3-e7f54dbc8625"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("8816a160-9b0b-453b-a564-c5f5a7f179d8"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("9007f20e-2dbb-4a16-a133-7876f36e772d"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("9b59efdd-c1ef-4c90-87c2-379a1bb6da7a"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("9ed633ed-942f-4be6-a627-394e0dcc0fa0"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("a17c4417-61a2-4932-b988-0cbffae49940"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("a642f3c5-4e96-4131-ad5c-52f5a6594e5f"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("a86dab2e-5f86-486d-85dc-35298f75834b"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("ae214892-1bb5-441c-a03a-a27f0210bcd9"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("b20ccb2d-205a-42ef-94c5-6e80a47b5d8e"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("b2d249b5-4215-4aa7-88f6-b3831eff5f4d"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("bafdbb35-ab1b-42d5-a127-2757ff31b3aa"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c0ad6371-94c1-4556-bc4a-c20b83cf13de"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c2d3b691-4962-4bba-86ce-edb3b030dd8d"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c2dd9171-3128-4275-bc0c-04daba85c5c0"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c40098f4-e3a1-4d2d-a19e-5d4801299c6f"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("d0c2ff00-0264-4490-82f5-0871d5355361"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("d60a9162-4fc2-4265-8d12-291ab344432f"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("d9465ba6-8a98-44ee-89af-b8e53c53ee2e"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("de7b471b-af6c-4155-9bf5-a4d964678bc6"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("dfca5d02-0c40-46ee-a674-89543d1b6f2e"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("e02f6c8d-0e0b-43f8-a6f4-148a3c46ed3c"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("e2e38434-2d6a-4040-a6e3-d0f2934c9597"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("ea599c07-3902-47fd-8822-6878c8aa04b4"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("ebca884c-abef-4d3a-b2d6-b6ef87c94af8"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("ed927e79-fdb1-4a57-9bcc-7bcaebe43154"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("f7cd5a3f-15fe-441a-9599-3d76c11a73af"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("f7dac28c-5c83-4925-b334-c7db7680c988"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("ff7e50ef-778b-4d22-be3c-b9afbf7b93c9"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { new Guid("1f888604-02ae-4f98-ba63-3dfc2d729bde"), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(287), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(289), "Coca Cola" },
                    { new Guid("449e957d-15c8-40c8-9f68-bcc4288a7bcc"), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(223), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(274), "Brooks" },
                    { new Guid("524d9afa-3a6e-4640-aaf5-71febc4347cf"), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(293), "Ben & Jerrys" }
                });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "Id", "ClientId", "ClosingDate", "DateCreated", "DateUpdated", "OpeningDate", "Title", "WinnersDrawn" },
                values: new object[,]
                {
                    { new Guid("62538378-de06-4da0-b361-8f27f5430386"), new Guid("449e957d-15c8-40c8-9f68-bcc4288a7bcc"), new DateTime(2023, 4, 9, 18, 53, 22, 932, DateTimeKind.Local).AddTicks(299), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(304), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(306), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(297), "Product launch instant win", false },
                    { new Guid("d63d6620-ecc4-49f8-9f37-e2e2bddf494d"), new Guid("1f888604-02ae-4f98-ba63-3dfc2d729bde"), new DateTime(2023, 4, 9, 18, 53, 22, 932, DateTimeKind.Local).AddTicks(310), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(311), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(308), "Sampling with capital xtra", false },
                    { new Guid("f2413a3b-1058-45ff-bd46-07df8bbbbebb"), new Guid("524d9afa-3a6e-4640-aaf5-71febc4347cf"), new DateTime(2023, 4, 9, 18, 53, 22, 932, DateTimeKind.Local).AddTicks(317), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(318), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(319), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(315), "Share the love", false }
                });
        }
    }
}
