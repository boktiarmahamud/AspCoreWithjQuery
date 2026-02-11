# AspCoreWithjQuery

Simple ASP.NET Core MVC project demonstrating jQuery AJAX calls.

How to run
1. dotnet build
2. dotnet run
3. Open the site (usually https://localhost:5001) and navigate to Home -> Index.

Notes
- AJAX calls in `Views/Home/Index.cshtml` use POST to call `HomeController.Add`.
- If you prefer GET, change the controller action to accept GET.
- Add an antiforgery token to AJAX headers if you enable/require antiforgery in production.
