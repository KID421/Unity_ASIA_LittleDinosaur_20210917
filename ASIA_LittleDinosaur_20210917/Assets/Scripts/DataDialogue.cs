using UnityEngine;

// �إ߱M�פ������(menuName = "���W��") ��Ƨ�/�l���
[CreateAssetMenu(menuName = "KID/��ܸ��")]
/// <summary>
/// ��ܸ��
/// �O�s NPC �n�򪱮a������ܤ��e
/// </summary>
/// Scriptable Object �}���ƪ���G�N�{������x�s�� Project ��������
public class DataDialogue : ScriptableObject
{
    [Header("��ܪ̦W��")]
    public string nameDialogue;
    // Text Area (�̤p��ơA�̤j���) - �ȭ� string
    [Header("��ܤ��e"), TextArea(3, 5)]
    public string[] dialogues;
}
