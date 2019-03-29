<div>
    <p align="center">
    <img src="https://imgur.com/9E8hN79.png" alt="Homely - ASP.NET Core MVC Helpers" />
    </p>
</div>

# Homely - ASP.NET Core WebApi Template.
This library contains an _opinionated_ templated ASP.NET Core WebApi project. The template package is available on NuGet, which will allow new API's/microservices to be easily created via the CLI (command line interface) `dotnet new` tool/command. 

This library heavily leverages our other [helpers library](https://github.com/Homely/Homely.AspNetCore.Mvc.Helpers).


[![Build status](https://ci.appveyor.com/api/projects/status/qgijj9r1qx5yjmda/branch/master?svg=true)](https://ci.appveyor.com/project/Homely/homely-aspnetcore-webapi-template/branch/master)

---
## How to use
1. Install the template using the command line (we do this once, only):
```
dotnet new -i Homely.AspNetCore.WebApi.Template
```

2. Create a new project using the template (we do this every time we're creating a new web api):
```
dotnet new homelyapi -n YourOrg.YourServiceName.WebApi 
```

Optional settings:

| Argument | Description | Default Value | Sample Value |
| -------- | ----------- | ------------- | ------------ |
| `swagger-title` | Title for the Docs | `"My API"` | `"Awesome API"` |
| `swagger-version` | API Version | `v1` | `v2` |
| `swagger-routeprefix` | Root route to access the swagger docs | `"swagger"` | `"accounts/swagger "` |


The new API template will be created with the namespace specified in the `-n` parameter. 

## How it works
- The [template.json](.template.config\template.json) file configures how the template will be created.
- Note the `sourceName` property in that file with the value `Homely.ProjectName.WebApi`. This is the _default_ namespace for all the `.cs` files, which is replaced by the value in the `-n` parameter.
- The nuspec dictates this package is a special "template" file, via the `<packageType name="Template">` directive.
More info about templates: https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates
---

## Current default features
- Based off an Empty ASPNET Core 2.2 Web App.
- Uses `ProblemDetails` for consistent error models [Shoutout to [@khellang Middleware library](https://github.com/khellang/Middleware)]
- Default `HomeController` with default route "`/`". (You can optionally provide a nice text message / banner :)  )
- [Common JSON settings](https://github.com/Homely/Homely.AspNetCore.Mvc.Helpers#common-jsonserializersettings). (e.g. Camel casing, indenting, etc.)
- Serilog for logging (`Development` mode logs to `Console`). [Check here](https://github.com/serilog/serilog/wiki/Provided-Sinks) to use other sinks.
- Swagger and SwaggerUI (via [Swashbuckle Framework](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)) for API documentation.

These default _opinionated_ features were mostly derived from these projects:
- [Homely - ASP.NET Core 'Hosting' core application-library](https://github.com/Homely/Homely.AspNetCore.Hosting.CoreApp) - an opinioned program.cs class which is to reduce the ceremony for creating ASP.NET Core "Web Hosting" applications.
- [Homely - ASP.NET Core MVC Helpers](https://github.com/Homely/Homely.AspNetCore.Mvc.Helpers) - Some helper methods, models and extensions for an ASP.NET Core MVC application.
---

## Contributing

Discussions and pull requests are encouraged :) Please ask all general questions in this repo or pick a specialized repo for specific, targetted issues. We also have a [contributing](https://github.com/Homely/Homely/blob/master/CONTRIBUTING.md) document which goes into detail about how to do this.

## Code of Conduct
Yep, we also have a [code of conduct](https://github.com/Homely/Homely/blob/master/CODE_OF_CONDUCT.md) which applies to all repositories in the (GitHub) Homely organisation.

## Feedback
Yep, refer to the [contributing page](https://github.com/Homely/Homely/blob/master/CONTRIBUTING.md) about how best to give feedback - either good or needs-improvement :)

---
