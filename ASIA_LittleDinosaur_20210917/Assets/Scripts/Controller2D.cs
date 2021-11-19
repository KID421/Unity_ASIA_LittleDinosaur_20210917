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
}
