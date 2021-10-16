# Welcome to the **nanoFramework** Base Class Library for IL2C repository!

This is a special fork of nanoFramework's BCL, to compile with [IL2C](https://github.com/cyborgyn/IL2C/tree/feature/implement-ilcodes), and extend IL2C.Runtime with the required classes, functions.

## BCL Flavours

The .NET **nanoFramework** Base Class Library is provided in two flavours: with or without support for System.Reflection namespace. The reason for this is that the reflection API adds up a significant size to the DLL and image size. For targets with smaller flash this can be prohibitive.

To Compile with IL2C, only the reflectionless flavor is in focus currently.

## Getting started

* You will need the VisualStudio Extension of nanoFramework, to be able to open this solution
* Compile it
* Use the in-dev version of [IL2C](https://github.com/cyborgyn/IL2C/tree/feature/implement-ilcodes) to transpile the mscorlib.dll to C source code
* Copy the source code into IL2C.Runtime (work in progress)
* Set the C compiler to provide EXTCORLIB definition
* Recompile IL2C.Runtime with ./build-runtime.sh (work in progress)

## Unit Test

nanoFramework has a dedicated [Unit Test framework](https://github.com/nanoframework/nanoFramework.TestFramework). This repository has Unit Test and you will find all of them under the `Tests` folder. The main solution embed all all the tests as well. You can run them directly from Visual Studio and create new tests. For more information on the [Unit Test Framework](https://docs.nanoframework.net/content/unit-test/index.html).

CoreLibrary has specific needs that differ from what you'll find in the documentation:

- You need to have the nanoFramework.TestFramework as a nuget package as it will bring the nanoCLR Win32 emulator
- You need to remove the reference to mscorlib, nanoFramework.TestFramework and nanoFramework.UnitTestLauncher
- Use project reference instead for all those 3 elements

You can then run the test either on a real device, either in the emulator as described in the documentation. You may have to manually flash your device for the mscorlib version to match the one you are building on.

**Important**: Any new code checked in this repository will have to:

- have a proper test covering for all the methods, properties, events and the possible exceptions,
- do not break more of the the existing tests meaning, in other words, it should not create more issues than already existing.

### Test structure and project reference

All the projects are referenced based and to be able to run the tests in the pipeline, in command line and in Visual Studio, it does require a specific structure:

- The `NFUnitTestAdapter` project must be present and untouched. It does contains the core elements needed to have the nanoCLR Win32 application present.
- You need to have a `nano.runsettings` file in each sub directory you want to run the tests on from Visual Studio
- If you want to run the tests in command line you have to use the `Developer Command Prompt for VS 2019` then you can use from the home cloned lib-CoreLibrary directory a command line like this one:

```cmd
vstest.console.exe .\Tests\NFUnitTestBitConverter\bin\Release\NFUnitTest.dll  /Settings:.\Tests\NFUnitTestAdapater\nano.runsettings /TestAdapterPath:.\nanoFramework.TestFramework\source\TestAdapter\bin\Debug\net4.8 /Diag:.\log.txt /Logger:trx
```

*Notes*:

- You have to build the TestAdapter from the source in this case. You can use the path to the nuget as well, this will have the same effect.
- you have full diagnostic enabled in this case.

## Feedback and documentation

For documentation, providing feedback, issues and finding out how to contribute please refer to the [Home repo](https://github.com/nanoframework/Home).

Join our Discord community [here](https://discord.gg/gCyBu8T).

## Credits

The list of contributors to this project can be found at [CONTRIBUTORS](https://github.com/nanoframework/Home/blob/main/CONTRIBUTORS.md).

## License

The **nanoFramework** Class Libraries are licensed under the [MIT license](LICENSE.md).

## Code of Conduct

This project has adopted the code of conduct defined by the Contributor Covenant to clarify expected behavior in our community.
For more information see the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

### .NET Foundation

This project is supported by the [.NET Foundation](https://dotnetfoundation.org).
