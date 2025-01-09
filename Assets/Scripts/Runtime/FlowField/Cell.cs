using UnityEngine;
using System;
using System.Collections.Generic;

namespace YKGame.Runtime
{
	/// <summary>
	/// 地图格子信息
	/// </summary>
	public class Cell
	{
		public Vector3 worldPos;		// 坐标（格子中心）
		public Vector2Int gridIndex;	// 格子索引（对应unity中的x,z平面索引）

		public byte cost;				// 基础积分值

		public ushort bestCost;			// 与目标点的距离积分
		
		public GridDirection bestDirection;     // 与目标点的最优方向向量

		public Dictionary<int, List<string>> contents;  //当前格子内的实体类型和sGuid

		public GameObject gameObject;

		private int gridOrder;
		public int GridOrder { get => gridOrder; }			// 格子排序顺序（从左到右，下到上）

		public Cell(Vector3 _worldPos, Vector2Int _gridIndex,int gridOrder)
		{
			worldPos = _worldPos;
			gridIndex = _gridIndex;

			this.gridOrder = gridOrder;

			cost = 1;

			bestCost = ushort.MaxValue;

			bestDirection = GridDirection.None;

			contents = new Dictionary<int, List<string>>();
		}

		public Cell(bool _walkable, Vector3 _worldPos, Vector2Int _gridIndex)
		{
			worldPos = _worldPos;
			gridIndex = _gridIndex;
			
			cost = 1;
			
			bestCost = ushort.MaxValue;
			
			bestDirection = GridDirection.None;

			contents = new Dictionary<int, List<string>>();
		}

		/// <summary>
		/// 设置格子的基础代价类型
		/// </summary>
		/// <param name="amnt">阻挡类型（65535-阻挡，1-可行走类型，其他-自定义代价类型）</param>
		public void IncreaseCost(int amnt)
		{
			if (cost == byte.MaxValue) { return; }
			if (amnt >= 255) { MakeImpassible(); }
			else { cost = (byte)amnt; };
		}

		/// <summary>
		/// 设为阻挡
		/// </summary>
		public void MakeImpassible()
		{
			cost = byte.MaxValue;
		}

		/// <summary>
		/// 设置成目的地
		/// </summary>
		public void SetAsDestination()
		{
			cost = 0;
			bestCost = 0;

			bestDirection = GridDirection.None;
		}

		public void ResetCell()
		{
			//cost = 1;
			bestCost = ushort.MaxValue;

			bestDirection = GridDirection.None;
		}
	}
}