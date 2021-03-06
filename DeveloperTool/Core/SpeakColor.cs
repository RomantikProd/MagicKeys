﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void SpeakColor()
{
int[] MP = MagicKeys.GetMousePosition();
Bitmap Screen = new Bitmap(1, 1);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(MP[0], MP[1], 00, 0, Screen.Size);
Color GetColor =  Screen.GetPixel(0, 0);
string StrColor = String.Format("#{0:X6}", GetColor.ToArgb() & 0x00FFFFFF);
MagicKeys.Speak(StrColor);
}

}
}