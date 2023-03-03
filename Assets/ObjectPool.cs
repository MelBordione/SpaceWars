using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool instance;
    private List<GameObject> objectInPool = new List<GameObject>();
    private int PoolSize = 50;

    [SerializeField] private GameObject bullet;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }

    void Start()
    {
        for (int i = 0; i<PoolSize; i++)              
        {
            GameObject obj = Instantiate(bullet);
            obj.SetActive(false);
            objectInPool.Add(obj);
        }
    }

    public GameObject GetObjectInPool()
    {
        for (int i = 0; i < objectInPool.Count; i++)

            if (!objectInPool[i].activeInHierarchy)
            {
                return objectInPool[i];
            }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
