﻿using Orchard.Data.Migration;
using Orchard.Recipes.Models;

namespace Orchard.Recipes
{
    public class Migrations : DataMigration
    {
        public int Create()
        {
            SchemaBuilder.CreateMapIndexTable(nameof(RecipeResultIndex), table => table
                .Column<string>("ExecutionId")
            );

            return 1;
        }
    }
}