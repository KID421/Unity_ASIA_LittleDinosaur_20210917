using UnityEngine;

/// <summary>
/// �{�ѧP�_�� (����)
/// </summary>
public class LearnCondition : MonoBehaviour
{
    public bool openDoor;
    public int score = 70;
    public string weapon = "�M�l";

    // �}�l�ƥ�G����C������@��
    private void Start()
    {
        #region �P�_�� if
        // �y�k�G
        // �� ���L�� �� true �|���� if �� {}
        // if (���L��) { �{�����e }
        if (true)
        {
            print("�{�ѧP�_�� if");
        }

        // �� ���L�� �� true �|���� if �� {}
        // �� ���L�� �� false �|���� else �� {}
        // if (���L��) { �{�����e }
        // else { �{�����e }
        if (openDoor)
        {
            print("�}���I");
        }
        else
        {
            print("�����I");
        }
        #endregion
    }

    // ��s�ƥ�G���@���Q�� (60 FPS)
    private void Update()
    {
        print("�������~");

        #region �P�_�� if
        // �_�h �p�G else if (���L��) { �{�����e } - if �U�� else �W�� - �L�ƶq����
        // �p�G ���� >= 60 �ή�
        // �p�G ���� >= 60 ���O >= 40 �ɦ�
        // �_�h �N ���ή�
        if (score >= 60)
        {
            print("�ή�~");
        }
        else if (score >= 40)
        {
            print("�ɦ�~");
        }
        else if (score >= 30)
        {
            print("��~");
        }
        else
        {
            print("���ή�");
        }
        #endregion

        #region �P�_�� switch
        // switch (��) 
        // {
        //    case "�M�l":
        //       �����O 10;
        //       break;
        //    case "�����j":
        //       �����O 1000;
        //       break;
        //    default:
        //       �o���O�Z��;
        //       break;
        // }

        switch (weapon)
        {
            case "�M�l":
                print("�����O 10");
                break;
            case "�����j":
                print("�����O 1000");
                break;
            default:
                print("�o���O�Z���I");
                break;
        }
        #endregion
    }
}
