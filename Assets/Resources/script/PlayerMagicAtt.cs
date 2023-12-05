using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagicAtt : MonoBehaviour
{
    public float shot_speed = 1000;
    protected Vector3 forward;
    protected Rigidbody rb;
    protected GameObject characterObject;
    private GameObject attPrefab;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();            // プレハブのRigidbodyを取得
        forward = characterObject.transform.forward;    // Playerの前方を取得
        Destroy(this.attPrefab, 1f);                    // プレハブを1秒後破壊
    }

    void Update()
    {
        rb.velocity = forward * shot_speed;        // プレハブを移動させる
    }

    // 球のis triggerのチェックを外す
    // Enemyのis triggerのチェックを外す
    /*private void OnTriggerEnter(Collider other)
    {
        Debug.Log("衝突しました。");
        // 敵に衝突したら、プレハブを破壊
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(attPrefab);
        }
    }*/

    // Playerと生成されたプレハブのGameObjectのセッター
    public void SetObject(GameObject characterObject, GameObject attPrefab)
    {
        this.characterObject = characterObject;
        this.attPrefab = attPrefab;
    }
}