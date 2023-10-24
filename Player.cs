using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 씬이 넘어가도 유지할 데이터들 */

public static class Player
{
	private static int playerLevel;
    public static List<Sculpture> sculptures;
	public static int curSculpID;
	public static int doneCount = 0;

	//생성
	static Player()
	{
		playerLevel = 1;
		curSculpID = 1;
		setSculpturesInfo();
	}
	
	//캐릭터 레벨올라감
	public static void CheckLevel()
	{
		switch (doneCount)
		{
			case 4:
				Level = 2;
				break;
			case 8:
				Level = 3;
				break;
			case 12:
				Level = 4;
				break;
			default:
				Level = 5;
				break;
		}
	}
	//플레이어 레벨
	public static int Level
	{
		get { return playerLevel; }
		set { playerLevel = value; }
	}
	
	public static void setSculpturesInfo()
	{
		sculptures = new List<Sculpture>();
		sculptures.Add(new Sculpture(1, 10, "사과를", "나무"));
		sculptures.Add(new Sculpture(2, 10, "사과를", "돌"));
		sculptures.Add(new Sculpture(3, 10, "체리를", "나무"));
		sculptures.Add(new Sculpture(4, 10, "체리를", "돌"));
		sculptures.Add(new Sculpture(5, 10, "상어를", "나무"));
		sculptures.Add(new Sculpture(6, 10, "상어를", "돌"));
		sculptures.Add(new Sculpture(7, 10, "자동차를", "나무"));
		sculptures.Add(new Sculpture(8, 10, "자동차를", "돌"));
		sculptures.Add(new Sculpture(9, 10, "체스말을", "나무"));
		sculptures.Add(new Sculpture(10, 10, "체스말을", "돌"));
		sculptures.Add(new Sculpture(11, 10, "조각상을", "나무"));
		sculptures.Add(new Sculpture(12, 10, "조각상을", "돌"));
		sculptures.Add(new Sculpture(13, 10, "말을", "나무"));
		sculptures.Add(new Sculpture(14, 10, "말을", "돌"));
		sculptures.Add(new Sculpture(15, 10, "총을", "나무"));
		sculptures.Add(new Sculpture(16, 10, "총을" , "돌"));
	}
	
	public static void setRandScpt()
	{
		int a = Random.Range(0, 16);
		curSculpID = a;
	}
 
}
