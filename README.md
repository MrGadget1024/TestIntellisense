# TestIntellisense

This is a simple demo that `EditorBrowsable(EditorBrowsableState.Never` doesn't work as expected.

- TestClass is set as Release build, TestApp as Debug build
- TestClass is referenced directly to the Release DLL (copy local False), not the project in the solution
- In TestApp Module1, the HiddenProperty and HiddenMethod of TestClass should not appear in IntelliSense.
