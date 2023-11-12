// Each class will need some standardization. Group class members into sections to organize them:
// — Fields
// — Properties
// — Events / Delegates
// — Monobehaviour Methods (Awake, Start, OnEnable, OnDisable, OnDestroy,
// etc.)
// — Public Methods
// — Private Methods

using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    // Fields
    [SerializeField] private int myField1;
    [SerializeField] private float myField2;

    // Properties
    public int MyProperty1 { get; set; }
    public float MyProperty2 { get; set; }

    // Events / Delegates
    public event System.Action MyEvent;

    // MonoBehaviour Methods
    private void Awake()
    {
        // Initialization code here
    }

    private void Start()
    {
        // Start-up code here
    }

    private void OnEnable()
    {
        // Activation code here
    }

    private void OnDisable()
    {
        // Deactivation code here
    }

    private void OnDestroy()
    {
        // Cleanup code here
    }

    // Public Methods
    public void PublicMethod1()
    {
        // Public method logic here
    }

    public void PublicMethod2(int parameter)
    {
        // Public method logic with parameters here
    }

    // Private Methods
    private void PrivateMethod1()
    {
        // Private method logic here
    }

    private void PrivateMethod2(float parameter)
    {
        // Private method logic with parameters here
    }
}
