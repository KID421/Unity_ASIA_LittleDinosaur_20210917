using UnityEngine;

/// <summary>
/// �ǲ߰j��
/// 1. while *
/// 2. do while
/// 3. for *
/// 4. foreach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    private void Start()
    {
        // �ݨD�G
        // ��X�Ʀr 1 ~ 10
        print("�Ʀr�G" + 1);
        print("�Ʀr�G" + 2);
        print("�Ʀr�G" + 3);
        print("�Ʀr�G" + 4);
        print("�Ʀr�G" + 5);
        print("�Ʀr�G" + 6);
        print("�Ʀr�G" + 7);
        print("�Ʀr�G" + 8);
        print("�Ʀr�G" + 9);
        print("�Ʀr�G" + 10);

        // �j��@�ΡG
        // ���ư���ۦP�{���åB�i�H���w����

        #region while �j��
        // �y�k
        // while (���L��) { �{�����e }
        // �S�ʡG�� ���L�� �� true �ɷ|������� {} ���쥬�L�� �� false 
        int i = 1;
        while (i < 11)
        {
            print("while �j��G" + i);
            i++;
        }
        #endregion

        #region for �j��
        // �y�k
        // for (��l�ȡF���L�ȡF�j�鵲����n���檺�{��) { �{�����e }
        for (int j = 1; j < 11; j++)
        {
            print("for �j��G" + j);
        }
        #endregion
    }
}
