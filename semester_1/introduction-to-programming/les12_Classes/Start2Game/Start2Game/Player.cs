using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2Game
{
	class Player
	{
		// ToDo 2 : Add the following properties to the Player class
		//          - Level (int) , default value 1
		//          - XP (int) , default value 0
		//          - Health (int) , default value 100
		public int level = 1;
		public int xp = 0;
		public int health = 100;

		// 3 : Add the following methods to the Player class
		//          - LevelUp() : increase the level by 1
		//          - GainXP(int amount) : increase the XP by the amount
		//          - ResetXP() : set the XP to 0
		//          - TakeDamage(int amount) : decrease the Health by the amount, if the Health is less than 0, set it to 0
		//          - GainHealth(int amount) : increase the Health by the amount
		//          - IsDead() : return true if the Health is less than or equal to 0

		public void LevelUp()
		{
			level++;
		}
		public void GainXP(int amount)
		{
			xp += amount;
		}
		public void ResetXP()
		{
			xp = 0;
		}
		public void TakeDamage(int amount)
		{
			health -= amount;
			if(health < 0)
				health = 0;
		}
		public void GainHealth(int amount)
		{
			health += amount;
		}
		public bool IsDead()
		{
			return health <= 0;
		}
	}
}
