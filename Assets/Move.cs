using UnityEngine;

public class Move : MonoBehaviour {

    // Vector3 goal = new Vector3(5, 0, 4);
 public float speed = 2.0f;
    public Transform goal;

    void Start() {

        // this.transform.Translate(goal);
    }

    private void Update() {
        Vector3 direction = goal.position - this.transform.position;
        this.transform.Translate(direction.normalized * speed * Time.deltaTime );
    }
}
