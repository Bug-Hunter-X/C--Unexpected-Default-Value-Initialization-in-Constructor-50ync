public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass()
    {
        // Explicitly initialize MyProperty in the constructor to prevent potential issues
        MyProperty = 0; 
    }

    public void MyMethod()
    {
        // Access and modify MyProperty
        MyProperty++;
    }

    // Added a method to demonstrate the issue and its resolution
    public int GetMyProperty()
    {
        return MyProperty;
    }
}