using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviour : MonoBehaviour
{
	public Text label;
	public FloatData dataObj;

	private void Start()
	{
		label = GetComponent<Text>();
		UpdateLable();
	}

	public void UpdateLable()
	{
		label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
	}
}
