using UnityEngine;

public class TerrainCreation : MonoBehaviour
{
    public const int LENGTH = 100;
    public const int SCAN_RADIUS = 2;

    int[] heightmap = new int[LENGTH];
    GameObject[] heightGOs = new GameObject[LENGTH];

    void Start()
    {
        for (int i = 0; i < LENGTH; i++)
        {
            heightmap[i] = UnityEngine.Random.Range(1, 20);

            GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            heightGOs[i] = gameObject;

            TransformGO(i);
        }

        for (int i = 0; i < 2; i++)
        {
            Smooth();
        }

        //Camera.main.transform.position = new Vector3(LENGTH / 2, LENGTH / 2, -LENGTH);
    }

    void TransformGO(int i)
    {
        GameObject gameObject = heightGOs[i];
        gameObject.transform.localScale = new Vector3(1, heightmap[i], 1);
        gameObject.transform.localPosition = new Vector3(i, heightmap[i] / 2f, 0);
        gameObject.name = "column " + i + " (height=" + heightmap[i] + ")";
    }

    void Smooth()
    {
        for (int i = 0; i < heightmap.Length; i++)
        {
            int height = heightmap[i];

            int heightSum = 0;
            int heightCount = 0;

            for (int n = i - SCAN_RADIUS;
                     n < i + SCAN_RADIUS + 1;
                     n++)
            {
                if (n >= 0 &&
                    n < heightmap.Length)
                {
                    int heightOfNeighbour = heightmap[n];

                    heightSum += heightOfNeighbour;
                    heightCount++;
                }
            }

            int heightAverage = heightSum / heightCount;
            heightmap[i] = heightAverage;

            TransformGO(i);
        }
    }
}
