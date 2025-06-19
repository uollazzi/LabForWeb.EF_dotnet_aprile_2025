# Entity Framework

## Database First Scaffold
```
Scaffold-DbContext -DataAnnotations -OutputDir Models -ContextDir . -Force 'Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Initial Catalog=CSharpEF' Microsoft.EntityFrameworkCore.SqlServer
```

```
Scaffold-DbContext -DataAnnotations -OutputDir Models -ContextDir . -Force 'Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Initial Catalog=AdventureWorksLT2019' Microsoft.EntityFrameworkCore.SqlServer
```