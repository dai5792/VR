using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magiccontroll : MonoBehaviour
{
    /// <summary>
    /// 弾の速度 (m/s)
    /// </summary>
    [SerializeField]
    private float m_bulletSpeed = 5.0f;

    // Update is called once per frame
    void Update(){
        //弾を前に進ませる
        transform.position +=
            transform.forward * m_bulletSpeed * Time.deltaTime;
    }
}
