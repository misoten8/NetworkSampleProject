using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーン遷移管理クラス
/// 製作者：実川
/// </summary>
public class SceneRootManager : SingletonMonoBehaviour<SceneRootManager>
{
	/// <summary>
	/// 現在使用されているシーン
	/// </summary>
	public Define.SceneType CurrentSceneType
	{
		get { return Instance._currentSceneType; }
		private set { Instance._currentSceneType = value; }
	}
	[SerializeField]
	private Define.SceneType _currentSceneType = Define.SceneType.None;

	/// <summary>
	/// シーンを切り替える
	/// </summary>
	static public void TransScene(Define.SceneType type)
	{
		Instance._currentSceneType = type;
		SceneManager.LoadScene(Instance._currentSceneType.ToString());
	}
}
