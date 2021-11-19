using UnityEngine;

/// <summary>
/// ����G2D ��V���b�Ҧ�
/// </summary>
public class Controller2D : MonoBehaviour
{
    #region ���G���}
    [Header("���ʳt��"), Range(0, 100)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 1500)]
    public float jump = 500;
    #endregion

    /// <summary>
    /// ���餸�� Rigidbody 2D
    /// </summary>
    private Rigidbody2D rig;

    private void Start()
    {
        // ������� = ���o����<2D ����>()
        rig = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Update �� 60 FPS
    /// �T�w��s�ƥ�G50 FPS
    /// �B�z���z�欰
    /// </summary>
    private void FixedUpdate()
    {
        Move();
    }

    #region ��k
    /// <summary>
    /// 1. ���a�O�_�������ʫ��� ���k��V�� �� A�BD
    /// 2. ���󲾰ʦ欰 (API)
    /// </summary>
    private void Move()
    {
        // h �� ���w�� ��J.���o�b�V(�����b) - �����b�N���k��P AD
        float h = Input.GetAxis("Horizontal");
        print("���a���k����ȡG" + h);
    }
    #endregion
}
