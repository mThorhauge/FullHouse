using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class townScroll : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private float currentYpos;


    // Use this for initialization
    void Start() {
        currentYpos = 0.0f;
        //print(this.transform.position.y);
    }

    // Update is called once per frame
    void Update() {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log ("OnDrag");

        this.transform.position = new Vector3(320, eventData.position.y - currentYpos);
            
        if (this.transform.position.y <= 173)
        {
            this.transform.position = new Vector3(320, 173);
            //print(">0");
        }
        if (this.transform.position.y >= 956)
        {
            this.transform.position = new Vector3(320, 956);
            //print(">0");
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        //currentYpos = this.transform.position.y;

        //print(this.transform.position.y);

    }

}
