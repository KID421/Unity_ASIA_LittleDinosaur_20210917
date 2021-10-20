using UnityEngine;      // �ޥ� Unity �����R�W�Ŷ��G�i�H�ϥΦ��Ŷ��� API

// ������
// KID 2021
// class ���O�G�@�Ӫ����Ź�
// �y�k�G���O ���O�W�� { ���O���e (���O����) }
// �����O�n�b Unity ���ϥΥ����~�� MonoBehaviour
// �A���ҬO����X�{�G()�B[]�B{}�B<>�B''�B""
public class Car : MonoBehaviour
{
    // ��� Field�G�O�s�U�����������
    // �y�k�G�׹��� ������� ���W�� ���w �w�]�� �����Ÿ�
    // �� �|�j�`�������G
    // ��@�ơG�x�s�S���p���I�����t��� - int
    // �B�I�ơG�x�s�a���p���I�����t��� - float
    // �r�@��G�x�s��r��T            - string
    // ���L�ȡG�O�P�_ true�Bfalse      - bool
    // �� �׹���
    // �p�H�G��L���O����s���B����� private (�w�]��)
    // ���}�G��L���O�i�H�s���B��@�� publiv
    // ����ݩ� Attritube
    // �y�k�G[�ݩʦW��(��)]
    // 1. ���D Header(�r��)
    // 2. ���� Tooltip(�r��)
    // 3. �d�� Range(�̤p�ȡA�̤j��) - �ȾA�Ω�ƭ����� int�Bfloat
    [Header("CC ��"), Range(500, 5000)]
    public int cc = 1000;
    [Header("���q"), Range(1, 10)]
    public float weight = 3.5f;
    [Header("�~�P�W��"), Tooltip("�o�O���l���~�P�W��")]
    public string brand = "���h";
    [Header("�O�_���ѵ�")]
    public bool hasSkyWindow = true;
}