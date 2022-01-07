using UnityEngine;
using UnityEngine.UI;       // �ޥ� ���� API
using UnityEngine.Events;   // �ޥ� �ƥ� API

/// <summary>
/// ���˨t��
/// </summary>
public class HurtSystem : MonoBehaviour
{
    [Header("���")]
    public Image imgHpBar;
    [Header("��q")]
    public float hp = 100;
    [Header("�ʵe�Ѽ�")]
    public string parameterDead = "Ĳ�o���`";
    [Header("���`�ƥ�")]
    public UnityEvent onDead;

    private float hpMax;
    private Animator ani;

    // ����ƥ�G�b Start ���e����@��
    private void Awake()
    {
        ani = GetComponent<Animator>();
        hpMax = hp;
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="damage">�����쪺�ˮ`</param>
    public void Hurt(float damage)
    {
        hp -= damage;
        imgHpBar.fillAmount = hp / hpMax;
        if (hp <= 0) Dead();
    }

    /// <summary>
    /// ���`
    /// </summary>
    private void Dead()
    {
        ani.SetTrigger(parameterDead);
        onDead.Invoke();
    }
}
