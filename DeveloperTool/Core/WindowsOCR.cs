﻿using System;
using System.Threading;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void WindowsOCR()
{
if (DP[0] == 0)
{
MagicKeys.Speak("No rect for OCR");
return;
}
int[] MP = MagicKeys.GetMousePosition();
string Text = MagicKeys.ImgToText(DP[0], DP[1], MP[0]-(DP[0]/2), MP[1]-(DP[1]/2), OCRZoom);
Thread.Sleep(500);
OCRR = Text;
MagicKeys.Speak(Text);
}

}
}