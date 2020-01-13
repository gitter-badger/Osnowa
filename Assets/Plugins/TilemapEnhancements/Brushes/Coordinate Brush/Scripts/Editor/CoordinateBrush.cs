﻿using UnityEditor;
using UnityEngine;

namespace Assets.Plugins.TilemapEnhancements.Brushes.Coordinate_Brush.Scripts.Editor
{
    [CustomGridBrush(true, false, false, "Coordinate Brush")]
    public class CoordinateBrush : UnityEditor.Tilemaps.GridBrush {
        public int z = 0;

        public override void Paint(GridLayout grid, GameObject brushTarget, Vector3Int position)
        {
            var zPosition = new Vector3Int(position.x, position.y, z);
            base.Paint(grid, brushTarget, zPosition);
        }
        
        public override void Erase(GridLayout grid, GameObject brushTarget, Vector3Int position)
        {
            var zPosition = new Vector3Int(position.x, position.y, z);
            base.Erase(grid, brushTarget, zPosition);
        }
        
        public override void FloodFill(GridLayout grid, GameObject brushTarget, Vector3Int position)
        {
            var zPosition = new Vector3Int(position.x, position.y, z);
            base.FloodFill(grid, brushTarget, zPosition);
        }

        [MenuItem("Assets/Create/Coordinate Brush")]
        public static void CreateBrush()
        {
            string path = EditorUtility.SaveFilePanelInProject("Save Coordinate Brush", "New Coordinate Brush", "asset", "Save Coordinate Brush", "Assets");

            if (path == "")
                return;

            AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<CoordinateBrush>(), path);
        }
    }

    [CustomEditor(typeof(CoordinateBrush))]
    public class CoordinateBrushEditor : UnityEditor.Tilemaps.GridBrushEditor
    {
        private CoordinateBrush coordinateBrush { get { return target as CoordinateBrush; } }

        public override void PaintPreview(GridLayout grid, GameObject brushTarget, Vector3Int position)
        {
            var zPosition = new Vector3Int(position.x, position.y, coordinateBrush.z);
            base.PaintPreview(grid, brushTarget, zPosition);
        }

        public override void OnPaintSceneGUI(GridLayout grid, GameObject brushTarget, BoundsInt position, GridBrushBase.Tool tool, bool executing)
        {
            base.OnPaintSceneGUI(grid, brushTarget, position, tool, executing);
            if (coordinateBrush.z != 0)
            {
                var zPosition = new Vector3Int(position.min.x, position.min.y, coordinateBrush.z);
                BoundsInt newPosition = new BoundsInt(zPosition, position.size);
                Vector3[] cellLocals = new Vector3[]
                {
                    grid.CellToLocal(new Vector3Int(newPosition.min.x, newPosition.min.y, newPosition.min.z)),
                    grid.CellToLocal(new Vector3Int(newPosition.max.x, newPosition.min.y, newPosition.min.z)),
                    grid.CellToLocal(new Vector3Int(newPosition.max.x, newPosition.max.y, newPosition.min.z)),
                    grid.CellToLocal(new Vector3Int(newPosition.min.x, newPosition.max.y, newPosition.min.z))
                };

                Handles.color = Color.blue;
                int i = 0;
                for (int j = cellLocals.Length - 1; i < cellLocals.Length; j = i++)
                {
                    Handles.DrawLine(cellLocals[j], cellLocals[i]);
                }
            }
            Handles.Label(grid.CellToWorld(new Vector3Int(position.x, position.y, coordinateBrush.z)), new Vector3Int(position.x, position.y, coordinateBrush.z).ToString());
        }
    }
}
