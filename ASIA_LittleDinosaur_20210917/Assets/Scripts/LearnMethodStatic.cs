using UnityEngine;

/// <summary>
/// �ǲ��R�A��k
/// </summary>
public class LearnMethodStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A��k
        // �I�s��k
        // �y�k�G���O�W��.�R�A��k�W��(�������޼�)�F
        int rInt = Random.Range(1, 3);
        print("�H����� 1 �P 3�G" + rInt);
        print("-99 ������ȡG" + Mathf.Abs(-99));
    }
}
