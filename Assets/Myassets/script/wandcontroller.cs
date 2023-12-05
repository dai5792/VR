using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wandcontroller : MonoBehaviour
{
    /// <summary>
    /// 魔法のプレハブ。
    /// 発砲した際に、このオブジェクトを弾として実体化する。
    /// </summary>
    [SerializeField]
    private GameObject m_magicPrefab = null;

    /// <summary>
    /// 銃口の位置。
    /// 銃弾を実体化する時の位置や向きの設定などに使用する。
    /// </summary>
    [SerializeField]
    private Transform m_muzzlePos = null;

    /// <summary>
    /// VRコントローラーのトリガーが握られた時に呼び出す。
    /// </summary>
    public void Activate()
	{
        ShootAmmo();
    }

    /// <summary>
    /// 銃弾を生成する。
    /// </summary>
    private void ShootAmmo()
	{
        //弾のプレハブか銃口位置が設定されていなければ処理を行わず帰る。ついでに煽る。
        if(m_magicPrefab == null ||
            m_muzzlePos == null)
		{
            Debug.Log(" Inspector の設定が間違ってるでww m9(^Д^)ﾌﾟｷﾞｬｰ ");
            return;
		}

        //弾を生成する。
        GameObject magicObj = Instantiate(m_magicPrefab);

        //弾の位置を、銃口の位置と同一にする。
        magicObj.transform.position = m_muzzlePos.position;

        //弾の向きを、銃口の向きと同一にする。
        magicObj.transform.rotation = m_muzzlePos.rotation;

    }
}
