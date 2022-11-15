using UnityEngine;
using System.Collections;

[System.Serializable]
public class Mission
{
	public enum MissionType
	{
		Distance,
		DistanceWithNoCoins,
		DistanceWithNoPowerUps,
		FailBetween,
		Coin,
		PowerUps,
		ExtraSpeed,
		Shield,
		Abracadabra,
		Obstacles,
		Revive,
		BirdBrown,
		BirdBody,
		BirdWhite,
		StorkTall
	};

	public enum GoalType
	{
		InOneRun,
		InMultipleRun,
		InShop,
		Other
	};

	public string name = "";

	public MissionType missionType = MissionType.Distance;
	public GoalType goalType = GoalType.InOneRun;

	public string description = "";

	public int valueA = 0;
	public int valueB = 0;

	int storedValue = 0;
	int startingValue = 0;

	bool completed = false;

	public void SetStoredValue(int v)
	{
		storedValue = v;
		startingValue = v;
	}

	public int StoredValue()
	{
		return storedValue;
	}

	public void ModifyStoredValue(bool addValue, int amount)
	{
		if (addValue)
			storedValue += amount;
		else
			storedValue = startingValue + amount;
	}

	public void ResetThis()
	{
		storedValue = startingValue;
	}

	public bool Completed()
	{
		return completed;
	}

	public void Complete()
	{
		completed = true;
	}
}
