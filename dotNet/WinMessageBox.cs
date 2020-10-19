using System;
using System.Windows.Forms;

namespace Atomus.Control.MessageBox
{
    /// <summary>
    /// 사용자에게 메시지를 보여 주는 메시지 창을 표시합니다.이 창을 대화 상자라고도 합니다.이 창은 사용자가 닫을 때까지 응용 프로그램의 다른 동작을 차단하는 모달 창입니다.
    /// System.Windows.Forms.MessageBox에는 사용자에게 필요한 정보와 명령을 제공하는 텍스트, 단추 및 기호가 포함될 수 있습니다.
    /// System.Windows.Forms.MessageBox로 표시가 되도록 구현 되어 있습니다.
    /// </summary>
    public class WinMessageBox : IMessageBox
    {
        DialogResult IMessageBox.Show(string text, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(text.Translate(args));

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(messageResult.Message.Translate(args));

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(text.Translate(args));
            }
        }
        DialogResult IMessageBox.Show(string text, string caption, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate());

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate());

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate());
            }
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons);
            }
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);
            }
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton);
            }
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions);
            }
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, bool displayHelpButton, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, displayHelpButton);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, displayHelpButton);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, displayHelpButton);
            }
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath);
            }
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, string keyword, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, keyword);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, keyword);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, keyword);
            }
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, HelpNavigator helpNavigator, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator);
            }
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, HelpNavigator helpNavigator, object parameter, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator, parameter);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator, parameter);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator, parameter);
            }
        }
        DialogResult IMessageBox.Show(AtomusException exception)
        {
            return System.Windows.Forms.MessageBox.Show(exception.Message, exception.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        DialogResult IMessageBox.Show(Exception exception)
        {
            if (exception.InnerException != null)
                return System.Windows.Forms.MessageBox.Show(exception.InnerException.Message, exception.InnerException.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return System.Windows.Forms.MessageBox.Show(exception.Message, exception.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args));

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(_Owner, messageResult.Message.Translate(args));

                return ((IMessageBox)this).Show(_Owner, messageResult.Message, messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args));
            }
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate());

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(_Owner, messageResult.Message.Translate(args), caption.Translate());

                return ((IMessageBox)this).Show(_Owner, messageResult.Message, messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate());
            }
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(_Owner, messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons);

                return ((IMessageBox)this).Show(_Owner, messageResult.Message, messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons);
            }
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(_Owner, messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);

                return ((IMessageBox)this).Show(_Owner, messageResult.Message, messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);
            }
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(_Owner, messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton);

                return ((IMessageBox)this).Show(_Owner, messageResult.Message, messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton);
            }
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(_Owner, messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions);

                return ((IMessageBox)this).Show(_Owner, messageResult.Message, messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions);
            }
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(_Owner, messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath);

                return ((IMessageBox)this).Show(_Owner, messageResult.Message, messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath);
            }
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, string keyword, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, keyword);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(_Owner, messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, keyword);

                return ((IMessageBox)this).Show(_Owner, messageResult.Message, messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, keyword);
            }
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, HelpNavigator helpNavigator, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(_Owner, messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator);

                return ((IMessageBox)this).Show(_Owner, messageResult.Message, messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator);
            }
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, HelpNavigator helpNavigator, object parameter, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator, parameter);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.Forms.MessageBox.Show(_Owner, messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator, parameter);

                return ((IMessageBox)this).Show(_Owner, messageResult.Message, messageResult.Title, messageResult.MessageBoxButtons, messageResult.MessageBoxIcon, args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator, parameter);
            }
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, AtomusException exception)
        {
            return System.Windows.Forms.MessageBox.Show(_Owner, exception.Message, exception.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, Exception exception)
        {
            if (exception.InnerException != null)
                return System.Windows.Forms.MessageBox.Show(_Owner, exception.InnerException.Message, exception.InnerException.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return System.Windows.Forms.MessageBox.Show(_Owner, exception.Message, exception.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        Message.MessageResult GetMessage(string text)
        {
            try
            {
                string[] temps;
                Message.MessageResult messageResult;

                if (!text.Contains("-"))
                    return null;

                temps = text.Split('-');

                if (temps.Length < 2)
                    return null;

                if (temps[1].Length < 5)
                    return null;

                try
                {
                    if (temps[1].Length == 5 || temps[1].Substring(5, 1) != " ")
                        messageResult = ((Message.IMessageSource)this.CreateInstance("MessageSource")).GetMessage(temps[0], temps[1].Substring(0, 5), text);
                    else
                        messageResult = ((Message.IMessageSource)this.CreateInstance("MessageSource")).GetMessage(temps[0], temps[1].Substring(0, 5), text.Substring(temps[0].Length + 7));
                }
                catch (Exception ex)
                {
                    Diagnostics.DiagnosticsTool.MyTrace(ex);

                    messageResult = new Message.MessageResult();
                    if (temps[1].Length == 5 || temps[1].Substring(5, 1) != " ")
                        messageResult.Message = text;
                    else
                        messageResult.Message = text.Substring(temps[0].Length + 7);
                }

                if (messageResult.Message.Contains("^"))
                    messageResult.Message = messageResult.Message.Substring(0, messageResult.Message.IndexOf('^'));

                return messageResult;
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return null;
            }
        }
    }
}