using System.Reflection;
using System.Resources;

// Versioning using the NuGet format:

// A specific version number is in the form Major.Minor.Patch[-Suffix], where the components have the following meanings:
//
// Major: Breaking changes
// Minor: New features, but backwards compatible
// Patch: Backwards compatible bug fixes only
// -Suffix(optional)
//
// Examples:
// 1.0.1
// 6.11.1231
// 4.3.1-rc
// 2.2.44-beta1

// Do note that Microsoft can't agree on what a _build number_ is. Best practice is to use the last field (revision in .Net
// Framework nomenclature) for the number from the buildserver.

// Reference:   https://docs.microsoft.com/en-us/nuget/reference/package-versioning
//              https://docs.microsoft.com/en-us/dotnet/standard/library-guidance/versioning
//              https://docs.microsoft.com/en-us/dotnet/framework/app-domains/assembly-versioning
//              https://stackoverflow.com/questions/64602/what-are-differences-between-assemblyversion-assemblyfileversion-and-assemblyin
//              https://stackoverflow.com/questions/62353/what-are-the-best-practices-for-using-assembly-attributes

// Specifies the version of the assembly being attributed.
// CONSIDER only including a major version in the AssemblyVersion.
[assembly: AssemblyVersion("1.0.0.0")]

// Instructs a compiler to use a specific version number for the Win32 file version
// resource. The Win32 file version is not required to be the same as the assembly's
// version number.
// CONSIDER including a continuous integration build number as the AssemblyFileVersion revision.
//      For example, you are building version 1.0.0 of your project, and the continuous integration
//      build number is 99 so your AssemblyFileVersion is 1.0.0.99.
// DO use the format Major.Minor.Build.Revision for file version.
//      Where the build-field is used for the patch-number
[assembly: AssemblyFileVersion("1.0.0.0")]

// Defines additional version information for an assembly manifest.
// AVOID setting the assembly informational version yourself.
[assembly: AssemblyInformationalVersion("1.0.0 Dev build")]


#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
 [assembly: AssemblyConfiguration("Dev-Release")]
#endif

[assembly: AssemblyProduct("BuildScriptExample")]
[assembly: AssemblyCompany("My Imaginary company")]
[assembly: AssemblyCopyright("Copyright © Håkon K. Olafsen 2019")]
[assembly: AssemblyTrademark("No trademark")]
[assembly: NeutralResourcesLanguage("en")]
