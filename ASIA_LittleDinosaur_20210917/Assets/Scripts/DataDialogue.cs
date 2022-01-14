using UnityEngine;

// 建立專案內的選單(menuName = "選單名稱") 資料夾/子資料
[CreateAssetMenu(menuName = "KID/對話資料")]
/// <summary>
/// 對話資料
/// 保存 NPC 要跟玩家說的對話內容
/// </summary>
/// Scriptable Object 腳本化物件：將程式資料儲存至 Project 內的物件
public class DataDialogue : ScriptableObject
{
    [Header("對話者名稱")]
    public string nameDialogue;
    // Text Area (最小行數，最大行數) - 僅限 string
    [Header("對話內容"), TextArea(3, 5)]
    public string[] dialogues;
}
