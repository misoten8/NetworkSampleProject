using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// RankMessage クラス
/// 製作者：実川
/// </summary>
public class RankMessage : MonoBehaviour
{
	[SerializeField]
	Text message;

	[SerializeField]
	string constMessage;

	[SerializeField]
	FrontLine frontLine;

	void Update ()
	{
		message.text = constMessage + frontLine.GetFirstPlayer().name;
	}
}
