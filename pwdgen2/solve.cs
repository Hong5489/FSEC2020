using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
public class Program
{
	private static readonly string PasswordHash = "BIGBROTHERCORP";
    private static readonly string SaltKey = "MEINSALT";
	public static string Decrypt(byte[] cipherTextBytes, string IV)
	{
		byte[] bytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(32);
		ICryptoTransform transform = new RijndaelManaged
		{
			Mode = CipherMode.CBC,
			Padding = PaddingMode.None
		}.CreateDecryptor(bytes, Encoding.ASCII.GetBytes(IV));
		MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[cipherTextBytes.Length];
		int count = cryptoStream.Read(array, 0, array.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return Encoding.UTF8.GetString(array, 0, count).TrimEnd("\0".ToArray());
	}
	public static void Main()
	{
		string iV = "3058591d-a6f3-48";
		byte[] cipherTextBytes = {123, 10, 249, 199, 50, 139, 247, 110, 218, 26, 232, 15, 23, 216, 142, 169, 11, 163, 168, 169, 99, 56, 37, 9, 58, 170, 41, 142, 30, 241, 223, 199};
		Console.WriteLine(Decrypt(cipherTextBytes, iV));
	}
}