# Geosynkronisering

[Changelog](./CHANGELOG.md)

[UML Model](https://rawgit.com/kartverket/geosynkronisering/master/uml/HTML/index.htm)

[Downloads](https://github.com/kartverket/geosynkronisering/releases)

## Alternative subscriber for non-windows

https://github.com/kartverket/geosynkronisering/tree/fixDotnetstandard/Kartverket.Geosynkronisering.Subscriber/Test_Subscriber_NetCore

Deprecated version: https://github.com/kartverket/CORESubscriber

## Oppdatering til sqlite i Subsscriber f.o.m. v 1.2.3

I versjon 1.2.3 ble abonnenten sin subscriber database endret til SQLite fra SQL Server Compact.

Konvertering skjer på følgende måte:

Last ned sqlite-tools-win32-x86-3310100.zip fra SQLite Download Page https://sqlite.org/download.html: A bundle of command-line tools for managing SQLite database files, including the command-line shell program, the sqldiff.exe program, and the sqlite3_analyzer.exe program.

SQL Server Compact to SQLite: http://erikej.blogspot.com/2013/03/sql-server-compact-code-snippet-of-week.html In order to create a SQLite database for the script file created (c:\temp\nwlite.sql), you can use the sqlite3.exe command line utility like so: sqlite3 nwlite.db < nwlite.sql

Eksempel:

Kopier inn følgende på samme mappe (i dette eksempelet NyTest):

Program: ExportSqlCe40.exe sqldiff.exe sqlite3.exe sqlite3_analyzer.exe

SQL server compact database: geosyncDB.sdf

Lage scriptet test.sql: C:\testSQLCompact2SQlite\NyTest>ExportSqlCe40.exe "Data Source=C:\testSQLCompact2SQlite\nytest\geosyncDB.sdf" test.sql sqlite

Import inn i ny sqlite base geosyncDB.db: sqlite3 geosyncDB.db < test.sql

## External tools

[A nice tool for creating featureStores and sql from xsd](https://github.com/JuergenWeichand/deegree-cli-utility)

[Handy tool for editing Sql Server Compact files (use the 4.0 version)](https://github.com/ErikEJ/SqlCeToolbox/releases)

## Development

### WSDL svcutil
Diff showing needed edits to autogenerated code from svcutil: https://github.com/kartverket/geosynkronisering/commit/6b39e295fa45dc15b80a0e5eac6c95864386b855

