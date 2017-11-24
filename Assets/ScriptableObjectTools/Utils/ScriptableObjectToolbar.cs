#if !UNITY_5_1_OR_NEWER
using UnityEditor;

public class ScriptableObjectToolbar {
    [MenuItem("Assets/Create/GameEvent")]
    public static void CreateAsset() {
        ScriptableObjectUtility.CreateAsset<GameEvent>();
    }

    [MenuItem("Assets/Create/GameObjectSet")]
    public static void CreateGameObjectSetAsset() {
        ScriptableObjectUtility.CreateAsset<GameObjectSet>();
    }
}
#endif