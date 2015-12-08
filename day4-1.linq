<Query Kind="Statements">
  <Reference Relative="..\..\Aon - Surplus Lines\main\packages\Newtonsoft.Json.5.0.6\lib\net45\Newtonsoft.Json.dll">C:\projects\Aon - Surplus Lines\main\packages\Newtonsoft.Json.5.0.6\lib\net45\Newtonsoft.Json.dll</Reference>
  <Reference Relative="..\..\Rightpoint.Common\trunk\Rightpoint.Common\bin\Debug\Rightpoint.Common.dll">C:\projects\Rightpoint.Common\trunk\Rightpoint.Common\bin\Debug\Rightpoint.Common.dll</Reference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>Rightpoint.Common</Namespace>
  <Namespace>Rightpoint.Common.Cache</Namespace>
  <Namespace>Rightpoint.Common.Configuration</Namespace>
  <Namespace>Rightpoint.Common.Controls</Namespace>
  <Namespace>Rightpoint.Common.Extensions</Namespace>
  <Namespace>Rightpoint.Common.Services</Namespace>
  <Namespace>System.Security.Cryptography</Namespace>
</Query>

var prefix = "pqrstuv";
ThreadLocal<MD5> hasher = new ThreadLocal<MD5>(() => MD5.Create());

Enumerable.Range(0, int.MaxValue).AsParallel().Select(i => new { i = i, hash = hasher.Value.ComputeHash(Encoding.ASCII.GetBytes(prefix + i))}).Where(i => i.hash[0] == 0 && i.hash[1] == 0 && i.hash[2] >> 4 == 0).First().Dump();