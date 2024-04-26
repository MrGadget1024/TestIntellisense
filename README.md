# TestIntellisense

This is a simple demo that `EditorBrowsable(EditorBrowsableState.Never)` doesn't work as expected.

This was created for [this bug report](https://github.com/dotnet/roslyn/issues/71209).

- TestClass is set as Release build, TestApp as Debug build
- TestClass is referenced directly to the Release DLL (copy local False), not the project in the solution
- In TestApp Module1, the HiddenProperty and HiddenMethod of TestClass should not appear in IntelliSense.
