using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace HellstoneEdits
{
	public class HellstoneEdits : Mod
	{
		public override void AddRecipes()
		{
			RecipeFinder HBR = new RecipeFinder();
			HBR = new RecipeFinder();
			HBR.AddIngredient(ItemID.Hellstone, 3);
			HBR.AddIngredient(ItemID.Obsidian);
			HBR.AddTile(TileID.Hellforge);
			HBR.SetResult(ItemID.HellstoneBar);
			Recipe HBRR = HBR.FindExactRecipe();
			if (HBR != null)
			{
				RecipeEditor HBE = new RecipeEditor(HBRR);
				HBE.DeleteRecipe();
			}

			ModRecipe HSB = new ModRecipe(this);
			HSB.AddIngredient(ItemID.Hellstone, 5);
			HSB.AddTile(TileID.Hellforge);
			HSB.SetResult(ItemID.HellstoneBar);
			HSB.AddRecipe();
		}
	}
}

