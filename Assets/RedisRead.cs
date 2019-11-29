using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamDev.Redis;

public class RedisRead : MonoBehaviour
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

    [SerializeField]
    private string[] hashResults;

    private int rotation = 0;

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
        LoadHashs();
    }

    private string userKey()
    {
        return "user_" + UserID;
    }

    void LoadHashs()
    {
        redis.SendCommand(RedisCommand.HGETALL, userKey());
        hashResults = redis.ReadMultiString();

        for (int i = 0; i < hashResults.Length / 2; ++i)
        {
            TransformWithString(hashResults[i * 2], hashResults[i * 2 + 1]);
        }
    }

    void TransformWithString(string field, string value)
    {
        switch (field)
        {
            case "RightPos":
                RightHand.transform.position = StringToVec3(value);
                break;
            case "RightRot":
                RightHand.transform.rotation = StringToQuaternion(value);
                break;
            case "LeftPos":
                LeftHand.transform.position = StringToVec3(value);
                break;
            case "LeftRot":
                LeftHand.transform.rotation = StringToQuaternion(value);
                break;
            case "HeadPos":
                Head.transform.position = StringToVec3(value);
                break;
            case "HeadRot":
                Head.transform.rotation = StringToQuaternion(value);
                break;
            default:
                Debug.Log(field + " is not difined params.");
                break;
        }
    }

    Vector3 StringToVec3(string value)
    {
        string[] ss = value.Split(',');
        return new Vector3(float.Parse(ss[0]), float.Parse(ss[1]), float.Parse(ss[2]));
    }

    Quaternion StringToQuaternion(string value)
    {
        string[] ss = value.Split(',');
        return new Quaternion(float.Parse(ss[0]), float.Parse(ss[1]), float.Parse(ss[2]), float.Parse(ss[3]));
    }
}
