using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttBehaviour : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // 生成したいプレハブをResources/MagicPrefabs配下のプレハブを指定する。
        GameObject shotObject = (GameObject)Resources.Load("Prefabs/ErekiBall");

        // プレハブの生成場所を指定する。（今回はPlayerのポジションを指定）
        Vector3 playerPos = animator.GetComponent<Transform>().position;

        // プレハブの生成
        GameObject shot = Instantiate(shotObject, playerPos, Quaternion.identity);

        // キャラクターオブジェクトを取得
        GameObject playerGameObj = animator.GetComponent<PlayerManager>().gameObject;

        // PlayerMagicAtt.csのSetObject()を呼び出し
        shot.GetComponent<PlayerMagicAtt>().SetObject(playerGameObj, shot);
    }
}