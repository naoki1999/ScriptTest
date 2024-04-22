using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private int mp = 53;  // 魔力

    // 魔法攻撃用の関数
    public void Magic(int damage)
    {

        if (mp >= 5)
        {
            // mpが5以上だった場合
            Debug.Log("魔法攻撃をした。残りmpは" + this.mp);
            // 残りmpを減らす
            this.mp -= damage;
        }
        else
        {
            //mpが足りない場合
            if (mp < 5)
            {
                Debug.Log("mpが足りないため魔法が使えない");
            }
        }     

    }

    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        //魔法攻撃用の関数を呼び出す
        lastboss.Magic(5);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
