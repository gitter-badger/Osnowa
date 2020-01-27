﻿namespace GameLogic.GridRelated
{
	using Assets.Plugins.TilemapEnhancements.Tiles.Rule_Tile.Scripts;
	using Osnowa.Osnowa.Core;

	public interface ITileMatrixUpdater
	{
		void Set(Position position, OsnowaTile tileToSet);
		void RefreshTile(Position position, int layer);
	}
}