using UnityEngine;

/// <summary>
/// �ǲ��R�A�ݩ� Static Property
/// </summary>
public class LearnPropertyStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A�ݩ�
        // ���o Get
        // �y�k�G���O�W��.�R�A�ݩʦW��
        print("�H���ȡG" + Random.value);
        print("�Ҧ���v���ƶq�G" + Camera.allCamerasCount);
        // �]�w Set - ����� Read Only �ݩʳ]�w
        // �y�k�G���O�W��.�R�A�ݩʦW�� ���w �ȡF
        Time.timeScale = 0.5f;
        Cursor.visible = false;
        
        // Random.value = 0.5f;     // Read Only ����]�w
    }
}
