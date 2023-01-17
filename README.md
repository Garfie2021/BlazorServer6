## Src_Dapper_PostgreSQL/BlazorApp1
Sample program that issues SQL statements from Blazor Server to PostgreSQL.
From .Net 6 Blazor Server, I created a sample that uses the Dapper+Npgsql NuGet package to issue SQL statements to a PostgreSQL database.

[Source code explanation page](https://blog.unikktle.com/blazor-server%e3%81%8b%e3%82%89-postgresql%e3%81%b8sql%e6%96%87%e3%82%92%e7%99%ba%e8%a1%8c%e3%81%99%e3%82%8b/)

---

## Src_Dapper_PostgreSQL_Transaction/BlazorApp1
Simple and fast DB transaction processing implemented with Blazor Server

From .Net 6 Blazor Server, I created a sample that uses the Dapper+Npgsql NuGet package to issue SQL statements to a PostgreSQL database.
This time, we implemented the database with PostgreSQL, but the implementation of DB transactions is the same for Oracle, SQLServer, and MySQL.

If business logic and database processing are implemented using Repository and Interface, the source code becomes complicated and maintainability decreases.
Implementing with a static class simplifies the source code and improves maintainability.
Unit tests are easy to implement for source code implemented with static classes.

There are too many projects that use repositories and interfaces to implement a large amount of useless processing, exploding man-hours and never ending development. Static should be used.
There is still someone who doesn't understand multithreading in C# and says "I'm worried about using static", and if that person's opinion is adopted and "static is prohibited", the development man-hours will explode.

[Source code explanation page](https://blog.unikktle.com/blazor-server%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab%e3%81%a7%e9%ab%98%e9%80%9f%e3%81%aadb%e3%83%88%e3%83%a9%e3%83%b3%e3%82%b6%e3%82%af%e3%82%b7%e3%83%a7/)
