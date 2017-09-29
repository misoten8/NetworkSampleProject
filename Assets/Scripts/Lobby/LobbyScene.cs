using UnityEngine;

/// <summary>
/// LobbyScene クラス
/// 製作者：実川
/// </summary>
public class LobbyScene : MonoBehaviour
{
	void Start ()
	{
		AudioManager.PlayBGM("DJ Striden - Level One");
		ParticleManager.Play("GoalEffect");
	}
}
