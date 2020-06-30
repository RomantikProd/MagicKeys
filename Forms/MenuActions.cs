using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class Menu : Form
{

public void Exit(object sender, EventArgs e)
{
MagicKeys.KeySwitch = 1;
MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 0);
MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 1);
MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 2);
Ni.Visible = false;
DialogResult result;
if (sender == null)
{
result = MessageBox.Show("Выйти", "Закрыть Magic Keys?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
}
else
{
result = MessageBox.Show("Выйти", "Закрыть Magic Keys?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
}
if (result == DialogResult.Yes)
{
Application.Exit();
}
else
{
Ni.Visible = true;
MagicKeys.RegisterHotKey(MagicKeys.HM.Handle, 0, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F1);
MagicKeys.RegisterHotKey(MagicKeys.HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
MagicKeys.RegisterHotKey(MagicKeys.HM.Handle, 2, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F3);
MagicKeys.KeySwitch = 0;
}
}

public void Help(object sender, EventArgs e)
{
string commandText = @"Руководство пользователя.html";
var proc = new System.Diagnostics.Process();
proc.StartInfo.FileName = commandText;
proc.StartInfo.UseShellExecute = true;
proc.Start();
}

public void Settings(object sender, EventArgs e)
{
SettingsForm Settings = new SettingsForm();
Settings.Show();
}

public void Register(object sender, EventArgs e)
{
RegisterForm Reg = new RegisterForm();
Reg.Show();
}

}
}