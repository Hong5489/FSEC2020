# PwdGen2 (Reverse)
[com.evilcorp.pwdgen.apk](com.evilcorp.pwdgen.apk)

We are given an APK file (Android app file)

We use Online Decompiler JADX to decompile it

We didn't find the flag, but find a interesting file [enc.bin](enc.bin) in assests folder

We found [MainActivity.java](MainActivity.java) , it mention about `PwdGen.MainActivity`

So we guess the main code its at [PwdGen.dll](PwdGen.dll) in assemblies folder

We saw some .NET file, so we try decompile it using ILSpy and we successfully decompiled it!!

Can try it at http://teamskr.rocks/tools under Reverse, we provided ILSpy reverse service

[Decompiled Code](code.cs)

The flag seems to be the key:
```cs
protected override void OnCreate(Bundle savedInstanceState)
{
    ((Activity)this).OnCreate(savedInstanceState);
    Platform.Init((Activity)(object)this, savedInstanceState);
    ((Activity)this).SetContentView(2131361818);
    Toolbar supportActionBar = ((Activity)this).FindViewById<Toolbar>(2131230884);
    ((AppCompatActivity)this).SetSupportActionBar(supportActionBar);
    string iV = "3058591d-a6f3-48";
    byte[] cipherTextBytes = Utils.ReadAsset("enc.bin", ((Context)this).get_Assets());
    key = Utils.Decrypt(cipherTextBytes, iV);
    ((View)((Activity)this).FindViewById<Button>(2131230868)).add_Click((EventHandler)BtnOnClick);
}
```

Then we try to decrypt using [online C# compiler](https://dotnetfiddle.net/) (because we don't have)

First we need to convert `enc.bin` to bytearray:
```py
text = open("enc.bin",'r').read()
print list(bytearray(text))
```

Then apply it to the script below and run it:
```cs
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
		// Convert enc.bin to bytearray
		byte[] cipherTextBytes = {123, 10, 249, 199, 50, 139, 247, 110, 218, 26, 232, 15, 23, 216, 142, 169, 11, 163, 168, 169, 99, 56, 37, 9, 58, 170, 41, 142, 30, 241, 223, 199};
		Console.WriteLine(Decrypt(cipherTextBytes, iV));
	}
}
```
[C# script](solve.cs)
[Online C# compiler with script](https://dotnetfiddle.net/BHT04c)

Thats it! Here's the flag!!
## Flag
```
fsGhost0fTh3P4stcyberx
```