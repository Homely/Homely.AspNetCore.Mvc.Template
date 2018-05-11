# Homely - ASP.NET Core MVC Template.
This library contains a templated ASP.NET Core MVC project. The template package is available on NuGet, which will allow new API's/microservices to be easily created using the code in this repository. 

This library heavily leverages our other [helpers library](https://github.com/Homely/Homely.AspNetCore.Mvc.Helpers).

---
## How to use
1. Install the template using the command line:
```
dotnet new -i homelyapi
```

2. Create a new project using the template:
```
dotnet new homelyapi -n YourOrg.YourServiceName.WebApi
```

The new API template will be created with the namespace specified in the `-n` parameter. 

## How it works
- The [template.json](.template.config\template.json) file configures how the template will be created.
- Note the `sourceName` property in the file, with the value `Homely.ProjectName.WebApi`. This is the namespace for all the .cs files, which is replaced by the value in the `-n` parameter.
- The nuspec dictates this package is a special "template" file, via the `<packageType name="Template">` directive.
More info about templates: https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates
---
## Current default features
- [Custom JSON formatting](https://github.com/Homely/Homely.AspNetCore.Mvc.Helpers#consistent-api-error-schema-and-json-responses)
- [Consistent error models](https://github.com/Homely/Homely.AspNetCore.Mvc.Helpers#500-internal-server-error-unhandled-errors-are-json-results)
- [Pre-action validation via FluentValidation](https://github.com/Homely/Homely.AspNetCore.Mvc.Helpers#automatic-model-validation-via-fluentvalidation)
- Swagger generation / UI via Swashbuckle
- Test project for controllers using xunit / TestServer
---

## Contributing

Discussions and pull requests are encouraged :) Please ask all general questions in this repo or pick a specialized repo for specific, targetted issues. We also have a [contributing](https://github.com/Homely/Homely/blob/master/CONTRIBUTING.md) document which goes into detail about how to do this.

## Code of Conduct
Yep, we also have a [code of conduct](https://github.com/Homely/Homely/blob/master/CODE_OF_CONDUCT.md) which applies to all repositories in the (GitHub) Homely organisation.

## Feedback
Yep, refer to the [contributing page](https://github.com/Homely/Homely/blob/master/CONTRIBUTING.md) about how best to give feedback - either good or needs-improvement :)

---
