<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="15.0.0" />
    <PackageReference Include="MSTest.TestAdapter" Version="1.3.2" />
    <PackageReference Include="MSTest.TestFramework" Version="1.3.2" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\PrimeSifting\PrimeSifting.csproj" />  
  </ItemGroup>

</Project>