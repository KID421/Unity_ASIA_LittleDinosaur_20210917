using UnityEngine;

/// <summary>
/// �ǲ߹B��l
/// 1. ���w =
/// 2. �ƾ� + - * / % ���W ++�B���� -- += -= *= /= %=
/// 3. ��� > < >= <= == !=
/// 4. �޿� �åB && �Ϊ� || �A�� !
/// </summary>
public class LearnOperator : MonoBehaviour
{
    #region ���w�B��l
    // ���w�B��l�S�ʡG
    // �� ���w�B��l������k��A���w������
    // 1 + 2 = 3
    public int number = 10;     // ���w�G�N�Ʀr 10 ���w����� number

    public float numberA = 10;
    public float numberB = 3;
    public int numberC = 30;
    public int numberD = 5;

    public int numberE = 9;
    public int numberF = 1;
    #endregion

    private void Start()
    {
        #region �ƾǹB��l
        print("�[�k�G" + (numberA + numberB));
        print("��k�G" + (numberA - numberB));
        print("���k�G" + (numberA * numberB));
        print("���k�G" + (numberA / numberB));
        print("�l�ơG" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC �� 1�G" + numberC);
        numberC--;                              // ����
        print("numberC �� 1�G" + numberC);

        numberD = numberD + 10;
        print("numberD �[ 10�G" + numberD);
        numberD += 10;                          // ���W���w + - * / %
        print("numberD �[ 10�G" + numberD);
        #endregion

        #region ����B��l
        // �@�ΡG�����ӭȡA�åB���o���L�ȵ��G
        print("E > F :" + (numberE > numberF));     // t
        print("E < F :" + (numberE < numberF));     // f
        print("E >= F :" + (numberE >= numberF));   // t
        print("E <= F :" + (numberE <= numberF));   // f
        print("E == F :" + (numberE == numberF));   // f
        print("E != F :" + (numberE != numberF));   // t
        #endregion

        #region �޿�B��l
        // �@�ΡG�����ӥ��L�ȡA�åB���o���L�ȵ��G
        // �åB�G�u�n���@�� false ���G�� false
        print("T && T :" + (true && true));         // t
        print("T && F :" + (true && false));        // f
        print("F && T :" + (false && true));        // f
        print("F && F :" + (false && false));       // f
        // �Ϊ̡G�u�n���@�� true ���G�� true
        print("T || T :" + (true || true));         // t
        print("T || F :" + (true || false));        // t
        print("F || T :" + (false || true));        // t
        print("F || F :" + (false || false));       // f
        // �A�� !
        // �@�ΡG�N���L�ȵ����ۤ�
        print("!true : " + (!true));                // f
        print("!false : " + (!false));              // t
        #endregion
    }
}
