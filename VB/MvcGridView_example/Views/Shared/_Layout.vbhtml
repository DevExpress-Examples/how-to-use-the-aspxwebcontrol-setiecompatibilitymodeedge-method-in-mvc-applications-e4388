<!DOCTYPE HTML>
<html>
<head>
    <title>@ViewBag.Title</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    @Html.DevExpress().GetStyleSheets(
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.All}
    )
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
    @Html.DevExpress().GetScripts(
        New Script With {.ExtensionSuite = ExtensionSuite.All}
    )
</head>
<body>
    @RenderBody()
</body>
</html>