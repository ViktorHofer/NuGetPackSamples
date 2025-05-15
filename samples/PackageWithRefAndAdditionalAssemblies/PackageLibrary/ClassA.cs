namespace PackageLibrary;

/// <summary>
/// This is a class in the PackageLibrary.
/// It references a class in the ReferencedLibrary.
/// </summary>
public class ClassA
{
    /// <summary>
    /// This method invokes a method from the ReferencedLibrary.
    /// </summary>
    public static void Invoke() => ReferencedLibrary.ClassB.Invoke();
}
