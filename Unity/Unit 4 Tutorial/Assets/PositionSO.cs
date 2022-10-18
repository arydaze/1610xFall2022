using UnityEngine;

[CreateAssetMenu]
public class PositionSO : ScriptableObject
{
	public float pos;

	public void UpdateValue(float coord)
	{
		pos += coord;
	}
}
