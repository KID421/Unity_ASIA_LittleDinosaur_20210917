using UnityEngine;

/// <summary>
/// 控制器：2D 橫向卷軸模式
/// </summary>
public class Controller2D : MonoBehaviour
{
    #region 欄位：公開
    [Header("移動速度"), Range(0, 100)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 1500)]
    public float jump = 500;
    #endregion

    /// <summary>
    /// 剛體元件 Rigidbody 2D
    /// </summary>
    private Rigidbody2D rig;
}
