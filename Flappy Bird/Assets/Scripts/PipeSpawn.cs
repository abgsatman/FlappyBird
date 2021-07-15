using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;

    void Start()
    {
        StartCoroutine(CreatePipe());
    }

    IEnumerator CreatePipe()
    {
        //for initial
        yield return new WaitForSeconds(2.5f);
        
        while(true)
        {
            Instantiate(pipe, new Vector3(pipe.transform.position.x, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.1f);
        }
    }
}
