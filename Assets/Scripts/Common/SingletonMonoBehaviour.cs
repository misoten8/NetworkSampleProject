using UnityEngine;

/// <summary>
/// シングルトン化クラス
/// このクラスを使用する場合派生先の方が先に呼ばれるため、継承先のクラスはAwakeを使用してはいけない
/// 製作者：実川
/// </summary>
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	/// <summary>
	/// 継承先クラスのインスタンス
	/// </summary>
	public static T Instance
	{
		get
		{	
			return _instance;
		}
		private set
		{
			_instance = value;
		}
	}
	private static T _instance = null;

	void Awake()
    {
        if (_instance == null)
        {
			_instance = (T)this;
			DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

	/// <summary>
	/// インスタンス生成
	/// </summary>
	public static void CreateInstance()
	{
		if(Instance == null)
		{
			new GameObject(nameof(T)).AddComponent<T>();
		}
	}

	/// <summary>
	/// インスタンス消去
	/// </summary>
	public static void DeleteInstance()
	{
		if (Instance != null)
		{
			Destroy(Instance.gameObject);
		}
	}
}