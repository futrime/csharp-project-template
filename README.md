# C# Project Template

A template for C# projects

## Usage

You can directly use this repository as a template for your own project. Before starting your project, you may need to modify the following files:

- `README.md`: This file.
- `LICENSE`: The license file.
- `CHANGELOG.md`: The changelog file.

I recommend removing everything under `src/` and regenerating them with your own project name. Here are some useful commands:

```bash
cd src
dotnet new console -o <project_name> --use-program-main
dotnet new xunit -o <project_name>.Tests
dotnet add <project_name>.Tests/<project_name>.Tests.csproj reference <project_name>/<project_name>.csproj
cd ..
```

## Contributing

If you have any suggestions or improvements, please submit [an issue](https://github.com/Futrime/CSharpProjectTemplate/issues/new) or a pull request.

## Thanks

- [A collection of `.gitignore` templates](https://github.com/github/gitignore)
- [A Collection of Useful .gitattributes Templates](https://github.com/alexkaratarakis/gitattributes)
- [Common C# code conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [keep a changelog](https://github.com/olivierlacan/keep-a-changelog)
- [Standard Readme](https://github.com/RichardLitt/standard-readme)
- [Unit testing best practices with .NET Core and .NET Standard](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)

## License

[Unlicense](/LICENSE) © Zijian Zhang
