using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace YKGame.Runtime
{
	public class FlowField
	{
		public Cell[,] grid { get; private set; }				// 地图格子数据
		public Vector2Int gridSize { get; private set; }		// 地图格子的宽高尺寸
		public float cellRadius { get; private set; }			// 格子半径

		public Cell destinationCell;							// 目标格子
		
		private float cellDiameter;                             // 格子直径

		public Vector3 firstCellWorldPos;                       // 起点格子的世界坐标

		public FlowField(float _cellRadius, Vector2Int _gridSize, Vector3 startPos)
		{
			firstCellWorldPos = startPos;
			cellRadius = _cellRadius;
			cellDiameter = _cellRadius * 2;
			gridSize = _gridSize;
		}


		/// <summary>
		/// 根据地图给子的宽高，创建地图的格子信息
		/// </summary>
		public void CreateGrid()
		{
			//Debug.Log("Creating Grid");
			grid = new Cell[gridSize.x, gridSize.y];

			for (int x = 0; x < gridSize.x; x++)
			{
				for (int y = 0; y < gridSize.y; y++)
				{
					Vector3 worldPos = new Vector3(cellDiameter * x + cellRadius, 0, cellDiameter * y + cellRadius) + firstCellWorldPos;
					grid[x, y] = new Cell(worldPos, new Vector2Int(x, y),gridSize.x * y + x);
				}
			}
		}

		/// <summary>
		/// 重置所有格子信息
		/// </summary>
		public void Reset()
		{
			foreach (Cell curCell in grid)
				curCell.ResetCell();
		}

		/// <summary>
		/// 根据目标点，计算地图中每个格子与目标点的距离积分值（积分越高表示越远）
		/// </summary>
		/// <param name="_destinationCell">目标点</param>
		public void CreateIntegrationField(Cell _destinationCell)
		{
			destinationCell = _destinationCell;

			destinationCell.bestCost = 0;

			Queue<Cell> cellsToCheck = new Queue<Cell>();

			cellsToCheck.Enqueue(destinationCell);

			//Debug.Log(cellsToCheck.Count);
			while (cellsToCheck.Count > 0)
			{
				Cell curCell = cellsToCheck.Dequeue();

				List<Cell> curNeighbors = GetNeighborCells(curCell.gridIndex, GridDirection.CardinalDirections);
				foreach (Cell curNeighbor in curNeighbors)
				{
					if (curNeighbor.cost == byte.MaxValue)
					{
						continue;
					}
					if (curNeighbor.cost + curCell.bestCost < curNeighbor.bestCost)
					{
						curNeighbor.bestCost = (ushort)(curNeighbor.cost + curCell.bestCost);
						cellsToCheck.Enqueue(curNeighbor);
					}
				}
			}
		}

		/// <summary>
		/// 创建索引范围内格子的流场向量
		/// </summary>
		/// <param name="startIndex"></param>
		/// <param name="endIndex"></param>
		public void CreateFlowField()
		{
			for (int x = 0; x < gridSize.x; x++)
			{
				for (int y = 0; y < gridSize.y; y++)
				{
					grid[x, y].bestDirection = GridDirection.None;

					List<Cell> curNeighbors = GetNeighborCells(grid[x, y].gridIndex, GridDirection.AllDirections);

					int bestCost = grid[x, y].bestCost;

					foreach (Cell curNeighbor in curNeighbors)
					{
						if (curNeighbor.bestCost < bestCost)
						{
							bestCost = curNeighbor.bestCost;
							grid[x, y].bestDirection = GridDirection.GetDirectionFromV2I(curNeighbor.gridIndex - grid[x, y].gridIndex);
						}
					}
				}
			}
		}

		/// <summary>
		/// 根据指定坐标，获取对应的格子信息
		/// </summary>
		/// <param name="worldPos"></param>
		/// <returns></returns>
		public Cell GetCellFromWorldPos(Vector3 worldPos)
		{
			worldPos -= firstCellWorldPos;

			float percentX = worldPos.x / (gridSize.x * cellDiameter);
			float percentY = worldPos.z / (gridSize.y * cellDiameter);

			percentX = Mathf.Clamp01(percentX);
			percentY = Mathf.Clamp01(percentY);

			int x = Mathf.Clamp(Mathf.FloorToInt((gridSize.x) * percentX), 0, gridSize.x - 1);
			int y = Mathf.Clamp(Mathf.FloorToInt((gridSize.y) * percentY), 0, gridSize.y - 1);
			return grid[x, y];
		}

		/// <summary>
		/// 根据指定格子的索引与邻居列表，获取每个邻居格子信息
		/// </summary>
		/// <param name="nodeIndex">指定格子索引</param>
		/// <param name="directions">邻居列表</param>
		/// <returns></returns>
		public List<Cell> GetNeighborCells(Vector2Int nodeIndex, List<GridDirection> directions)
		{
			List<Cell> neighborCells = new List<Cell>();
			for (int i = 0; i < directions.Count; i++)
			{
				Cell newNeighbor = GetCellAtRelativePos(nodeIndex, directions[i]);
				if (newNeighbor != null)
				{
					neighborCells.Add(newNeighbor);
				}
			}
			return neighborCells;
		}

		/// <summary>
		/// 获取格子的相对位置索引
		/// </summary>
		/// <param name="orignPos">指定的格子索引</param>
		/// <param name="relativePos">相对的邻居</param>
		/// <returns></returns>
		private Cell GetCellAtRelativePos(Vector2Int orignPos, Vector2Int relativePos)
		{
			Vector2Int finalPos = orignPos + relativePos;

			if (finalPos.x < 0 || finalPos.x >= gridSize.x || finalPos.y < 0 || finalPos.y >= gridSize.y)
			{
				return null;
			}

			else { return grid[finalPos.x, finalPos.y]; }
		}
	}
}