using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Camera GameCamera;
    [SerializeField]
    TextMeshProUGUI playerDescription;
    [SerializeField]
    TextMeshProUGUI shapeDescription;

    private Shape selectedShape;

    void Awake()
    {
        SetPlayerDescription(MainManager.Instance.PlayerName);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = GameCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var selectedShape = hit.collider.GetComponentInParent<Shape>();
                SetSelectedShape(selectedShape);
            }
        }
    }

    private void SetSelectedShape(Shape shape)
    {
        selectedShape = shape;
        SetShapeDescription(shape.Name);
    }

    private void SetPlayerDescription(string text)
    {
        Debug.Log("SetPlayerDescription");
        playerDescription.text = text;
    }

    public void SetShapeDescription(string text)
    {
        shapeDescription.text = text;
    }
}
