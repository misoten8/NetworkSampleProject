using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// BasePlayer クラス
/// 製作者：実川
/// </summary>
public class BasePlayer : MonoBehaviour
{
	[SerializeField]
	protected Rigidbody rb;

	[SerializeField]
	protected float power;

	[SerializeField]
	private UnityEngine.UI.Text goalMessage;

	[SerializeField]
	private FrontLine foreFront;

	void OnTriggerEnter(Collider collision)
	{
		switch(collision.tag)
		{
			// 終了処理
			case "Finish":
				if (!foreFront.IsFirstPlayer(gameObject.GetInstanceID())) return;
				goalMessage.text = name + " Who Finish!!";
				StartCoroutine(FuncCoroutine());
				break;
			// 落下処理
			case "Respawn":
				rb.velocity = new Vector3();
				transform.position = new Vector3(0.0f, 2.0f, transform.position.z);
				break;
		}
	}

	private IEnumerator FuncCoroutine()
	{
		yield return new WaitForSeconds(5.0f);
		UnityEngine.SceneManagement.SceneManager.LoadScene("Lobby");
	}
}
