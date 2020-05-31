using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanyShop.Migrations
{
    public partial class PopulateTablePies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table :"Pies", columns: new[] { "Name", "Price","ShortDescription","LongDescription","ImageUrl","ImageThumbnailUrl","IsPieOfTheWeek" },
               values:new object[]{ "Apple Pie","12.95","Our famous apple pies!","Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll.", 
                "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg" ,
                " https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", true });

            migrationBuilder.InsertData(table: "Pies", columns: new[] { "Name", "Price", "ShortDescription", "LongDescription", "ImageUrl", "ImageThumbnailUrl", "IsPieOfTheWeek" },
             values: new object[]{  "Blueberry Cheese Cake","18.95","You'll love it!","Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll." ,
               "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg" ,
               " https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",false });

            migrationBuilder.InsertData(table: "Pies", columns: new[] { "Name", "Price", "ShortDescription", "LongDescription", "ImageUrl", "ImageThumbnailUrl", "IsPieOfTheWeek" },
              values: new object[]{  "Cheese Cake","18.95","Plain cheese cake. Plain pleasure.","Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll.", 
              "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg" ,
              " https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", false });

            migrationBuilder.InsertData(table: "Pies", columns: new[] { "Name", "Price", "ShortDescription", "LongDescription", "ImageUrl", "ImageThumbnailUrl", "IsPieOfTheWeek" },
            values: new object[]{ "Cherry Pie", "15.95","A summer classic!","Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll.",
             "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
             "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", false });

            migrationBuilder.InsertData(table: "Pies", columns: new[] { "Name", "Price", "ShortDescription", "LongDescription", "ImageUrl", "ImageThumbnailUrl", "IsPieOfTheWeek" },
            values: new object[]{  "Christmas Apple Pie", "13.95","Happy holidays with this pie!","Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll" ,
            "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
            "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",false });

            migrationBuilder.InsertData(table: "Pies", columns: new[] { "Name", "Price", "ShortDescription", "LongDescription", "ImageUrl", "ImageThumbnailUrl", "IsPieOfTheWeek" },
            values: new object[]{ "Cranberry Pie","17.95","A Christmas favorite","Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll." ,
           "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg" ,
           "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg", false });


           migrationBuilder.InsertData(table: "Pies", columns: new[] { "Name", "Price", "ShortDescription", "LongDescription", "ImageUrl", "ImageThumbnailUrl", "IsPieOfTheWeek" },
          values: new object[]{ "Peach Pie","17.95","Sweet as peach","Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll." ,
         "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg" ,
         "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",false });


            migrationBuilder.InsertData(table: "Pies", columns: new[] { "Name", "Price", "ShortDescription", "LongDescription", "ImageUrl", "ImageThumbnailUrl", "IsPieOfTheWeek" },
              values: new object[]{ "Pumpkin Pie","12.95","Our Halloween favorite","Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll." ,
                   "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                   "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",true});


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
