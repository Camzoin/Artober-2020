using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLerper : MonoBehaviour
{
    //public float duration = 20, eaDuration;

    //public int difAmount;

    //float curTime = 0;

    //int curNum = 0;

    //public float[] randomNums;

    public Material skin;

    float time = 5f, curTime = 0;


    bool down = true;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    difAmount = randomNums.Length;

    //    eaDuration = duration / difAmount;

    //    skin.SetFloat("Random", randomNums[curNum]);
    //}

    //// Update is called once per frame
    //void Update()
    //{       
    //    curTime = curTime + Time.deltaTime;

    //    skin.SetFloat("Random", Mathf.Lerp(skin.GetFloat("Random"), randomNums[curNum + 1], curTime / eaDuration));

    //    if (skin.GetFloat("Random") - randomNums[curNum + 1] < 0.1 || randomNums[curNum + 1] - skin.GetFloat("Random")  < 0.1 && curTime > eaDuration) 
    //    {
    //        curNum = curNum + 1;

    //        curTime = 0;
    //    }

    //    if (curNum >= randomNums.Length - 1)
    //    {
    //        curNum = 0;
    //    }

    //    Debug.Log(curNum);
    //}

    private void Update()
    {

        skin.SetFloat("Random", Random.Range(3, 16));

        //scab random I think


        //skin.SetFloat("Random", curTime);


        //if (curTime > time)
        //{        
        //    down = true;
        //}

        //if (curTime < 0) 
        //{
        //    down = false;
        //}



        //if (down)
        //{
        //    curTime = curTime - Time.deltaTime;
        //}

        //else if (!down)
        //{
        //    curTime = curTime + Time.deltaTime;
        //}
    }
}