using UnityEngine;

/// <summary>
/// �ĤH�欰
/// �˴��ؼЪ���O�_�A�l�ܰϰ�
/// �l�ܻP�����ؼ�
/// </summary>
public class Enemy : MonoBehaviour
{
    #region ���
    [Header("�ˬd�l�ܰϰ�j�p�P�첾")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3TrackOffset;
    [Header("���ʳt��")]
    public float speed = 1.5f;
    [Header("�ؼйϼh")]
    public LayerMask layerTarget;
    #endregion

    #region �ƥ�
    private void OnDrawGizmos()
    {
        // ���w�ϥܪ��C��
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        // ø�s�ߤ���(���ߡA�ؤo)
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize);
    }
    #endregion

    #region ��k
    /// <summary>
    /// �ˬd�ؼЬO�_�b�ϰ줺
    /// </summary>
    private void CheckTargetInArea()
    {
        // 2D ���z.�л\����(���ߡA�ؤo�A����)
        Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize, 0);
    }
    #endregion
}
