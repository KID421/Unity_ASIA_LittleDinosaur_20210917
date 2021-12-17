using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// ��ܨt��
/// �N�ݭn��X����r�Q�Υ��r�ĪG�e�{
/// </summary>
public class DialogueSystem : MonoBehaviour
{
    [Header("��ܶ��j"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("�e����ܨt��")]
    public GameObject goDialogue;
    [Header("��ܤ��e")]
    public Text textContent;
    [Header("��ܧ����ϥ�")]
    public GameObject goTip;
    [Header("��ܫ���")]
    public KeyCode keyDialogue = KeyCode.Mouse0;

    private void Start()
    {
        // StartCoroutine(TypeEffect());
    }

    /// <summary>
    /// ���r�ĪG
    /// </summary>
    /// <param name="contents">�Q�n�X�{�b��ܨt�Ϊ���ܤ��e�A�ݨϥΦr��}�C</param>
    private IEnumerator TypeEffect(string[] contents)
    {
        // �󴫦W�٧ֱ��� Ctrl + R R
        // ���ե�
        // string test1 = "���o�A�A�n~";
        // string test2 = "��ܲĤG�q~";
        // string[] contents = { test1, test2 };

        goDialogue.SetActive(true);                         // ��ܹ�ܪ���

        for (int j = 0; j < contents.Length; j++)               // �M�M�Ҧ����
        {
            textContent.text = "";                          // �M���W����ܤ��e
            goTip.SetActive(false);                         // ���� ���ܹϥ� �T����

            for (int i = 0; i < contents[j].Length; i++)        // �M�M��ܪ��C�@�Ӧr
            {
                textContent.text += contents[j][i];             // �|�[��ܤ��e��r����
                yield return new WaitForSeconds(interval);
            }

            goTip.SetActive(true);                          // ��ܹ�ܧ����ϥ� �T����

            while (!Input.GetKeyDown(keyDialogue))          // �����a�S������ܫ���ɫ������
            {
                yield return null;                          // ���� null �@�Ӽv��ɶ�
            }
        }

        goDialogue.SetActive(false);                        // ���� ��ܪ���
    }

    /// <summary>
    /// �}�l���
    /// </summary>
    /// <param name="contents">�n��ܥ��r�ĪG����ܤ��e</param>
    public void StartDialogue(string[] contents)
    {
        StartCoroutine(TypeEffect(contents));
    }

    /// <summary>
    /// ������
    /// </summary>
    public void StopDialogue()
    {
        StopAllCoroutines();                // �����{
        goDialogue.SetActive(false);        // ���ù�ܤ���
    }
}