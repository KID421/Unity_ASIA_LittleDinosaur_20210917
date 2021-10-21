using UnityEngine;      // �ޥ� Unity �����R�W�Ŷ��G�i�H�ϥΦ��Ŷ��� API

// ������
// KID 2021
// class ���O�G�@�Ӫ����Ź�
// �y�k�G���O ���O�W�� { ���O���e (���O����) }
// �����O�n�b Unity ���ϥΥ����~�� MonoBehaviour
// �A���ҬO����X�{�G()�B[]�B{}�B<>�B''�B""
public class Car : MonoBehaviour
{
    #region ���y�k�Υ|�j�`������
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
    #endregion

    #region Unity ���������
    // �C��B�V�q (�y��)�B����B�C������B����
    // �C�� Color
    public Color color;
    public Color colorRed = Color.red;
    public Color colorYellow = Color.yellow;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color colorCustom2 = new Color(1, 0, 1, 0.5f);
    // �V�q 2 ~ 4 Vector
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Left = Vector2.left;
    public Vector2 v2Custom = new Vector2(1, 2);
    public Vector3 v3Custom = new Vector3(1, 2, 3);
    public Vector4 v4Custom = new Vector4(1, 2, 3, 4);
    // ���� Keycode
    public KeyCode keycode;
    public KeyCode keycodeMouseLeft = KeyCode.Mouse0;
    public KeyCode keycodeJump = KeyCode.Space;
    // �C������ GameObject
    public GameObject goCamera;
    public GameObject goCar;
    // ���� Component
    public Transform traCamera;
    public Camera cam;
    public SpriteRenderer spr;
    #endregion

    #region �ƥ�G�{�����J�f
    // �}�l�ƥ�G�C������ɰ���@��
    private void Start()
    {
        // �I�s��k�G��k�W��();
        Test();
        Drive80();
        Drive100();
        Drive(120);     // �I�s�ɶ�J���٬��G�޼�
        Drive(990);
        float w99 = ConvertWeight(9.9f);
        print("9.9 �ഫ�G" + w99);

        print("���q�ഫ�G" + ConvertWeight(weight));
    }
    #endregion

    #region ��k�y�k
    // ��k�G�O�s�{�����e���϶��A�t��k�B���z��
    // �y�k�G�׹��� �Ǧ^���� ��k�W�� (�Ѽ�1�A�Ѽ�2�A...�A�Ѽ�N) { �{�����e }
    // void �L�Ǧ^�G�ϥΤ�k�ɤ��|���Ǧ^���
    // �ۭq��k�G���|����A�����I�s�~�|����
    private void Test()
    {
        // ��X(�T��) - �N�T����X�� Unity �����O Console
        print("���o�A�U�w :D");
    }

    private void Drive80()
    {
        print("�}���ɳt�G" + 80);
        print("���ġG������");
    }

    private void Drive100()
    {
        print("�}���ɳt�G" + 100);
        print("���ġG������");
    }

    // �Ѽƻy�k�G������� �ѼƦW��
    private void Drive(int speed)
    {
        print("�}���ɳt�G" + speed);
        print("���ġG������");
    }

    private float ConvertWeight(float setWeight)
    {
        return setWeight * 50;
    }
    #endregion
}