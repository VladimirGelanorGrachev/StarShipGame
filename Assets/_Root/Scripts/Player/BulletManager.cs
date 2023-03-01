using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Networking;


public class BulletManager : MonoBehaviour
{
    public NetworkHash128 AssetId => _assetId;
    [SerializeField] private GameObject _bulletPrefab;
    private NetworkHash128 _assetId;

    void Start()
    {
        _assetId = _bulletPrefab.GetComponent<NetworkIdentity>().assetId;
        ClientScene.RegisterSpawnHandler(_assetId, SpawnBullet, UnSpawnBullet);
    }

    public GameObject SpawnBullet(Vector3 position)
    {
        return Instantiate(_bulletPrefab, position, Quaternion.identity);
    }

    public GameObject SpawnBullet(Vector3 position, NetworkHash128 assetId)
    {
        return SpawnBullet(position);
    }

    public void UnSpawnBullet(GameObject spawned)
    {
        Destroy(spawned);
    }
}
