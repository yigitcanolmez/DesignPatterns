///*
// tek bir instance oluşturur ve uygulama boyunca o instance kullanılır.
//global olarak erişilebilir
//sadece istendiği zaman oluşturulur.

//-
//unit testi zor

//+ ve -'ler singleton pattern için arttırılacak.
// */

using SingletonPattern;
using System.Diagnostics;

Stopwatch sw = new Stopwatch();

///**********************************************************************************************/
///* NORMAL */

//Console.WriteLine("BEFORE");
//// user eklemek için db istek atalım.
//sw.Start();
//new SqlConnection().ExecuteAsync();

//// category eklemek için db istek atalım
//new SqlConnection().ExecuteAsync();
//sw.Stop();

//Console.WriteLine("Normal : {0}", sw.Elapsed);

//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine("AFTER");

//sw.Reset();

///**********************************************************************************************/
///* SINGLETONE */
///**********************************************************************************************/

//// user eklemek için
//sw.Start();
//SingletonSqlConnection.Instance.ExecuteAsync();

//// category eklemek için
//SingletonSqlConnection.Instance.ExecuteAsync();
//sw.Stop();

//Console.WriteLine("Singleton : {0}", sw.Elapsed);

//sw.Reset();

//Console.WriteLine();
//Console.WriteLine("ASYNC");
//////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////
//// asenkron deneme yapalım.
sw.Start();

var actions = new List<Action>();
for (int i = 0; i < 15; i++)
{
    actions.Add(() => SingletonSqlConnection.Instance.ExecuteAsync());
}

var tasks = actions.Select(action => Task.Run(action)).ToList();
await Task.WhenAll(tasks);
sw.Stop();

Console.WriteLine("Thread Safe Singleton : {0}", sw.Elapsed);
