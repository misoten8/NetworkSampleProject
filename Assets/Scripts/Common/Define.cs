/// <summary>
/// Define クラス
/// 製作者：実川
/// </summary>
public static class Define
{
	/// <summary>
	/// BGMアセットを格納しているディレクトリパス
	/// </summary>
	public const string BGM_ASSET_DIRECTORY = "Audios/BGM/";

	/// <summary>
	/// SEアセットを格納しているディレクトリパス
	/// </summary>
	public const string SE_ASSET_DIRECTORY = "Audios/SE/";

	/// <summary>
	/// パーティクルアセットを格納しているディレクトリパス
	/// </summary>
	public const string PARTICLE_ASSET_DIRECTORY = "Prefabs/Common/Particles";

	/// <summary>
	/// シーンの種類
	/// </summary>
	public enum SceneType
	{
		None = -1,
		Lobby,
		Main,
		Max
	}
}
