// Declare variable and assign it as null.
FooBar fooBar = null;

// Dereference variable by calling ToString.
// This will throw a NullReferenceException.
_ = fooBar.ToString();

// The FooBar type definition.
record FooBar(int Id, string Name);
