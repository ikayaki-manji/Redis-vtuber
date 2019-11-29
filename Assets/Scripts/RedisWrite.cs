using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamDev.Redis;


public class RedisWrite : MonoBehaviour
{
    [SerializeField]
    private string redisHost;

    [SerializeField]
    private int redisPort = 6379;

    [SerializeField]
    private GameObject LeftHand;

    [SerializeField]
    private GameObject RightHand;

    [SerializeField]
    private GameObject Head;

    [SerializeField]
    private int UserID;

    private RedisDataAccessProvider redis;

    [ContextMenu("ConnectCheck")]
    private void ConnectCheck()
    {
        Connect();
        Debug.Log("Connect Success!");
    }

    void Connect()
    {
        redis = new RedisDataAccessProvider();
        redis.Configuration.Host = redisHost;
        redis.Configuration.Port = redisPort;
        redis.Connect();
    }

    void Start()
    {
        Connect();
    }

    void Update()
    {
        WriteHashs();
    }

    private string userKey()
    {
        return "user_" + UserID;
    }

    void WriteHashs()
    {
        redis.SendCommand(RedisCommand.HMSET, userKey(),
            "RightPos", PosToString(RightHand.transform.position),
            "RightRot", RotToString(RightHand.transform.rotation),
            "LeftPos", PosToString(LeftHand.transform.position),
            "LeftRot", RotToString(LeftHand.transform.rotation),
            "HeadPos", PosToString(Head.transform.position),
            "HeadRot", RotToString(Head.transform.rotation));
    }


    string PosToString(Vector3 pos)
    {

        return pos.x.ToString() + "," + pos.y.ToString() + "," + pos.z.ToString();
    }

    string RotToString(Quaternion rot)
    {

        return rot.x.ToString() + "," + rot.y.ToString() + "," + rot.z.ToString() + "," + rot.w.ToString();
    }
}
