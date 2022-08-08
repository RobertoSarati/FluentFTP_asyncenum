using (var ftp = new FluentFTP.FtpClient("ftp://test.rebex.net/", "demo", "password"))
{
	await foreach (var item in ftp.GetListingAsyncEnumerable())
	{
		Console.WriteLine(item.FullName);
	}
}
