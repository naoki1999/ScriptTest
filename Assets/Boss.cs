using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private int mp = 53;  // ����

    // ���@�U���p�̊֐�
    public void Magic(int damage)
    {

        if (mp >= 5)
        {
            // mp��5�ȏゾ�����ꍇ
            Debug.Log("���@�U���������B�c��mp��" + this.mp);
            // �c��mp�����炷
            this.mp -= damage;
        }
        else
        {
            //mp������Ȃ��ꍇ
            if (mp < 5)
            {
                Debug.Log("mp������Ȃ����ߖ��@���g���Ȃ�");
            }
        }     

    }

    // Start is called before the first frame update
    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();
        //���@�U���p�̊֐����Ăяo��
        lastboss.Magic(5);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
