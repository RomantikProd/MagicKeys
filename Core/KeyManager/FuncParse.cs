﻿using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static (string, string) FuncParse(string FuncParam)
{
string[] Temp = FuncParam.Split("|", 2);
return (Temp[0], Temp?[1]);
}

}
}