using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] carPrefabs;

    void Start()
    {
        int index = CarSelector.selectedCarIndex;
        Vector3 spawnPos = SceneManager.GetActiveScene().name == "circuit1"
            ? new Vector3(476.25f, 0.4207f, 155.14f)
            : new Vector3(427.34f, 0.8146f, 179.06f);

        Instantiate(carPrefabs[index], spawnPos, Quaternion.identity);
    }
}
