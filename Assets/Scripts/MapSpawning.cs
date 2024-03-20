using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UIElements;

public class MapSpawning : MonoBehaviour
{
    [SerializeField] public int mapsAmmount = 8;
    [SerializeField] public GameObject[] objectToPool;
    [SerializeField] public Maps[] mapPrefabs;
    [SerializeField] private bool usePool;
    private ObjectPool<Maps> pool;
    public int zPosiotion = 350;
    public int yPosition = -40;
    private int mapNumber = 2;


    void Start()
    {

        pool = new ObjectPool<Maps>(() =>
        {
            return Instantiate(mapPrefabs[mapNumber]);
        }, map =>
        {
            map.gameObject.SetActive(true);
        }, map =>
        {
            map.gameObject.SetActive(false);
        }, map =>
        {
            Destroy(map.gameObject);
        }, false, 10, 20);


        InvokeRepeating(nameof(Spawn), 2.5f, 2.5f);
    }
    void Update()
    {
        
    }

    private void Spawn()
    {
        for(var i = 0; i < mapsAmmount; i++)
        {
            var map = usePool ? pool.Get() : Instantiate(mapPrefabs[mapNumber], new Vector3(0, yPosition, zPosiotion), Quaternion.identity);
            zPosiotion += 150;
            map.Init(KillMap);
        }
    }

    private void KillMap(Maps maps)
    {
        if (usePool) pool.Release(maps);
        else Destroy(maps.gameObject);
    }
}
