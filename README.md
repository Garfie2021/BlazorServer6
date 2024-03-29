## BlazorServer6/Src_Dapper_ORACLE_Transaction/

From Blazor Server of .Net 6.0, using Dapper + Oracle.EntityFrameworkCore NuGet package, I created a sample that performs DB transaction processing to ORACLE database.

If business logic and database processing are implemented using Repository and Interface, the source code becomes complicated and maintainability decreases.
Implementing with a static class simplifies the source code and improves maintainability.
Unit tests are easy to implement for source code implemented with static classes.
There are too many projects that use repositories and interfaces to implement a large amount of useless processing, exploding man-hours and never ending development. Static should be used.
Even now, there are people who don't understand multithreading in C# and say "I'm worried about using static", and if that person's opinion is adopted and "static is prohibited", the development effort will explode.

The Visual Studio project template used this time is Visual Studio 2022 + .Net 6 + Blazor Server app without HTTPS.
Install Dapper/Oracle.EntityFrameworkCore NuGet package.
Unlike Oracle.ManagedDataAccess, Oracle.EntityFrameworkCore is convenient because you can execute OracleConnection without installing ORACLE Client separately.

[YouTube](https://youtu.be/yW5ueJsgpkw)
[Source code explanation page](https://blog.unikktle.com/blazor-server%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab%e3%81%a7%e9%ab%98%e9%80%9f%e3%81%aadb%e3%83%88%e3%83%a9%e3%83%b3%e3%82%b6%e3%82%af%e3%82%b7%e3%83%a7-3/)

---

## BlazorServer6/Src_Dapper_ORACLE_Transaction_StoredProcedure/

Simple and high-speed DB transaction processing (on ORACLE) implemented with Blazor Server and stored procedures

From .Net 6.0 Blazor Server, I created a sample that performs DB transaction processing when using Dapper + Oracle.EntityFrameworkCore NuGet package and using ORACLE database stored procedure (PL / SQL).

[YouTube](https://youtu.be/5lPvq1v8lgw)
[Source code explanation page](https://blog.unikktle.com/blazor-server%e3%81%a8%e3%82%b9%e3%83%88%e3%82%a2%e3%83%89%e3%83%97%e3%83%ad%e3%82%b7%e3%83%bc%e3%82%b8%e3%83%a3%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab-2/)

---


## BlazorServer6/Src_Dapper_PostgreSQL/
Sample program that issues SQL statements from Blazor Server to PostgreSQL.
From .Net 6 Blazor Server, I created a sample that uses the Dapper+Npgsql NuGet package to issue SQL statements to a PostgreSQL database.

[YouTube](https://youtu.be/iIy5jgl7ArI)
[Source code explanation page](https://blog.unikktle.com/blazor-server%e3%81%8b%e3%82%89-postgresql%e3%81%b8sql%e6%96%87%e3%82%92%e7%99%ba%e8%a1%8c%e3%81%99%e3%82%8b/)

---

## BlazorServer6/Src_Dapper_PostgreSQL_Transaction/
Simple and fast DB transaction processing implemented with Blazor Server

From .Net 6 Blazor Server, I created a sample that uses the Dapper+Npgsql NuGet package to issue SQL statements to a PostgreSQL database.
This time, we implemented the database with PostgreSQL, but the implementation of DB transactions is the same for Oracle, SQLServer, and MySQL.

If business logic and database processing are implemented using Repository and Interface, the source code becomes complicated and maintainability decreases.
Implementing with a static class simplifies the source code and improves maintainability.
Unit tests are easy to implement for source code implemented with static classes.

There are too many projects that use repositories and interfaces to implement a large amount of useless processing, exploding man-hours and never ending development. Static should be used.
There is still someone who doesn't understand multithreading in C# and says "I'm worried about using static", and if that person's opinion is adopted and "static is prohibited", the development man-hours will explode.

[YouTube](https://youtu.be/vA0kaUObOCU)
[Source code explanation page](https://blog.unikktle.com/blazor-server%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab%e3%81%a7%e9%ab%98%e9%80%9f%e3%81%aadb%e3%83%88%e3%83%a9%e3%83%b3%e3%82%b6%e3%82%af%e3%82%b7%e3%83%a7/)

---

## BlazorServer6/Src_Dapper_SQLServer_Transaction/

From .Net 6.0 Blazor Server, I created a sample that uses the Dapper+Microsoft.Data.SqlClient NuGet package to perform DB transaction processing to a SQLServer database.

If business logic and database processing are implemented using Repository and Interface, the source code becomes complicated and maintainability decreases.
Implementing with a static class simplifies the source code and improves maintainability.
Unit tests are easy to implement for source code implemented with static classes.
There are too many projects that use repositories and interfaces to implement a large amount of useless processing, exploding man-hours and never ending development. Static should be used.
Even now, there are people who don't understand multithreading in C# and say "I'm worried about using static", and if that person's opinion is adopted and "static is prohibited", the development effort will explode.

The Visual Studio project template used this time is Visual Studio 2022 + .Net 6 + Blazor Server app without HTTPS.
Install the Dapper/Microsoft.Data.SqlClient NuGet package.
Microsoft.Data.SqlClient is recommended instead of System.Data.SqlClient for connecting to SQLServer.

[YouTube](https://youtu.be/UKs5qsJLqvg)
[Source code explanation page](https://blog.unikktle.com/blazor-server%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab%e3%81%a7%e9%ab%98%e9%80%9f%e3%81%aadb%e3%83%88%e3%83%a9%e3%83%b3%e3%82%b6%e3%82%af%e3%82%b7%e3%83%a7-2/)

---

## BlazorServer6/Src_Dapper_SQLServer_Transaction_StoredProcedure/

Simple and fast DB transaction processing (on SQLServer) implemented with Blazor Server and stored procedures.

From .Net 6.0 Blazor Server, I created a sample that performs DB transaction processing when using the Dapper + Microsoft.Data.SqlClient NuGet package and using the SQLServer database stored procedure.

[YouTube](https://youtu.be/8qXnmSjWOIg)
[Source code explanation page](https://blog.unikktle.com/blazor-server%e3%81%a8%e3%82%b9%e3%83%88%e3%82%a2%e3%83%89%e3%83%97%e3%83%ad%e3%82%b7%e3%83%bc%e3%82%b8%e3%83%a3%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab/)

---


