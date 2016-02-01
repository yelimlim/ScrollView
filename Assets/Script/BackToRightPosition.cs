using UnityEngine;
using System.Collections;

public class BackToRightPosition : MonoBehaviour
{
	public UIDraggablePanel draggablePanel;
    public float duration = 0.0f;
	public Vector3 backPosition = new Vector3(1.0f, 1.0f, 1.0f);
	public GameObject moveGameObject;


	// Use this for initialization
	void Start ()
    {
		draggablePanel.onDragFinished += OnDragFinished;
	}

	// Update is called once per frame
	void Update ()
    {

	}

	void OnDragFinished()
	{
		Debug.Log ("drag finish");
		if(moveGameObject.transform.position.x > backPosition.x)
		{
			Tween();
		}
	}

	void OnDestroy()
	{
		draggablePanel.onDragFinished -= OnDragFinished;
		
	}

    void Tween()
    {
		TweenPosition tween = TweenPosition.Begin(moveGameObject, duration, backPosition);
        tween.duration = duration;
        tween.method = UITweener.Method.BounceIn;
    }
}
