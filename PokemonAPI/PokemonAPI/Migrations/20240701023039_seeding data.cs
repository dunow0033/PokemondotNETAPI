using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PokemonAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Description", "Index", "Name", "SpriteUrl", "Type" },
                values: new object[,]
                {
                    { 1, "A strange seed was planted on its back at birth. The plant sprouts and grows with this Pokémon.", 1, "Bulbasaur", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/1.png", "Grass/Poison" },
                    { 2, "When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs.", 2, "Ivysaur", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/2.png", "Grass/Poison" },
                    { 3, "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.", 3, "Venusaur", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/3.png", "Grass/Poison" },
                    { 4, "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.", 4, "Charmander", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/4.png", "Fire" },
                    { 5, "When it swings its burning tail, it elevates the temperature to unbearably high levels.", 5, "Charmeleon", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/5.png", "Fire" },
                    { 6, "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.", 6, "Charizard", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/6.png", "Fire/Flying" },
                    { 7, "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.", 7, "Squirtle", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/7.png", "Water" },
                    { 8, "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance.", 8, "Wartortle", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/8.png", "Water" },
                    { 9, "Once it takes aim at its enemy, it blasts out water with even more force than a fire hose.", 9, "Blastoise", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/9.png", "Water" },
                    { 10, "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.", 10, "Caterpie", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/10.png", "Bug" },
                    { 11, "This is its pre-evolved form. At this stage, it can only harden, so it remains motionless to avoid attack.", 11, "Metapod", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/11.png", "Bug" },
                    { 12, "In battle, it flaps its wings at great speed to release highly toxic dust into the air.", 12, "Butterfree", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/12.png", "Bug/Flying" },
                    { 13, "Often found in forests and grasslands. It has a sharp, toxic barb of around two inches on top of its head.", 13, "Weedle", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/13.png", "Bug/Poison" },
                    { 14, "Able to move only slightly. When endangered, it may stick out its stinger and poison its enemy.", 14, "Kakuna", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/14.png", "Bug/Poison" },
                    { 15, "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.", 15, "Beedrill", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/15.png", "Bug/Poison" },
                    { 16, "It usually hides in tall grass. Because it dislikes fighting, it protects itself by kicking up sand.", 16, "Pidgey", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/16.png", "Normal/Flying" },
                    { 17, "Very protective of its sprawling territorial area, this Pokémon will fiercely peck at any intruder.", 17, "Pidgeotto", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/17.png", "Normal/Flying" },
                    { 18, "When hunting, it skims the surface of water at high speed to pick off unwary prey such as Magikarp.", 18, "Pidgeot", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/18.png", "Normal/Flying" },
                    { 19, "Bites anything when it attacks. Small and very quick, it is a common sight in many places.", 19, "Rattata", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/19.png", "Normal" },
                    { 20, "It uses its whiskers to maintain its balance. It apparently slows down if they are cut off.", 20, "Raticate", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/20.png", "Normal" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
