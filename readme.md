## Synopsis

Creates a multiselection check box list based on the provided item source.

## Code Example

### Controller

```csharp
public IActionResult Index()
{
    List<CheckBoxItem> checkBoxItems = new List<CheckBoxItem>()
    {
        new CheckBoxItem(1, "Id 1: Unchecked Enabled", false, false),
        new CheckBoxItem(2, "Id 2: Checked Enabled", true, false),
        new CheckBoxItem(2, "Id 3: Unchecked Disabled", false, true),
        new CheckBoxItem(2, "Id 4: Checked Disabled", true, true)
    };

    return View(checkBoxItems);
}
```

```csharp
public IActionResult Result(List<int> selectedIds)
{
    return View(selectedIds);
}
```

### View

```html
<check-box-list name="selectedIds" items="Model" template="Bootstrap3Basic"></check-box-list>
```

### Style (Optional)

```CSS
.checkbox {
}

label.checkbox {
}

label.checkbox > input {
}
```


## Motivation

ASP.NET Core doesn't provide check box list tag helper which forces developers to write their own implementation. Therefore, I came with a tag helper that simplifies the developer's job so that they can focus on their domain rather creating their own.

## Installation

### Package Manager UI

In Solution Explorer, right-click References and choose Manage NuGet Packages.

Choose "nuget.org" as the Package source, select the Browse tab, search for CheckBoxList.Core, select that package in the list, and select Install:

Accept any license prompts.

If prompted to select a package management format, select PackageReference in the project file:

If prompted to review changes, select OK.

### Package Manager Console
Select the Tools > NuGet Package Manager > Package Manager Console menu command.
Once the console opens, check that the Default project drop-down list shows the project into which you want to install the package.

Enter the command Install-Package CheckBoxList.Core.