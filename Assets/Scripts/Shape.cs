using UnityEngine;

public abstract class Shape : MonoBehaviour // ABSTRACTION
{
    public virtual Color Color { get; }
    public virtual string Name { get; } = "Shape";

    void Awake()
    {
        Debug.Log($"Setting {Name}'s color to {Color}");
        SetColor(Color);
    }

    protected void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform == transform)
                {
                    OnClick();
                }
            }
        }
    }

    private void SetColor(Color color) // ENCAPSULATION
    {
        Renderer renderer = GetComponent<Renderer>();

        // Change the color of the material
        if (Color != null && renderer != null)
        {
            renderer.material.color = color;
        }
    }

    private void OnClick() // ENCAPSULATION
    {
        Debug.Log("Mouse down");
        GameManager gameManager = FindFirstObjectByType<GameManager>();
        gameManager.SetShapeDescription($"{Name} selected!");
    }
}
