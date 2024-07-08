using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurante.Migrations
{
    /// <inheritdoc />
    public partial class PopHamburgers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO Hamburgers (CategoryID, ShortDescription, LongDescription, HasInStock, ImageURL, ImageThumbURL, IsFavorite, HamburgerName, Price)" +
                                                 "VALUES (1, 'Delicious meat burger', 'Bread, cheese, 180g hamburger and bacon', 1, '~/img/hamburger/classic_burger.png', '~/img/hamburger/classic_burger.png', 0, 'Classic Burger', 12.50)");

            migrationBuilder.Sql("INSERT INTO Hamburgers (CategoryID, ShortDescription, LongDescription, HasInStock, ImageURL, ImageThumbURL, IsFavorite, HamburgerName, Price)" +
                                                 "VALUES (1, 'Delicious beef burger', 'Bread, cheese, 180g hamburger, pickles, ketchup, lettuce and tomato', 1, '~/img/hamburger/beef_burger.png', '~/img/hamburger/beef_burger.png', 0, 'Beef Burger', 14.50)");

            migrationBuilder.Sql("INSERT INTO Hamburgers (CategoryID, ShortDescription, LongDescription, HasInStock, ImageURL, ImageThumbURL, IsFavorite, HamburgerName, Price)" +
                                      "VALUES (2, 'Veggie burger', 'Bread, cheese, veggie hamburger, onions, ketchup, lettuce, tomato and mayo', 1, '~/img/hamburger/veggie_burger.png', '~/img/hamburger/veggie_burger.png', 0, 'Veggie Burger', 15.50)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("DELETE * FROM Hamburgers");

        }
    }
}
