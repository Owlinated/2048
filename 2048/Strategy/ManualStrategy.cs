﻿using System;
using System.Collections.Generic;
using _2048.Core;

namespace _2048.Strategy
{
	/// <summary>
	/// Ask user for input
	/// </summary>
	internal class ManualStrategy : IStrategy
	{
		private static readonly Dictionary<char, Direction> Keymap = new Dictionary<char, Direction>
		{
			{'w', Direction.Up},
			{'s', Direction.Down},
			{'a', Direction.Left},
			{'d', Direction.Right}
		};

		public Direction GetMove(Board board)
		{
			while (true)
				if (Keymap.TryGetValue((char)Console.Read(), out var direction) && board.ValidShifts.ContainsKey(direction))
					return direction;
		}
	}
}
