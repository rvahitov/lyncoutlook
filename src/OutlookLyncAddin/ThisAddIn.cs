using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Win32;
using OutlookLyncAddin.Common;
using OutlookLyncAddin.Common.Configuration;
using Office = Microsoft.Office.Core;

namespace OutlookLyncAddin
{
    public partial class ThisAddIn
    {
        private const string BeenTransformUserPropertyName = "OutlookLyncAddinBeenTransformed";
        private const int BeenTransformedValue = 1;
        private Explorer _activeExplorer;
        private Regex[] _phonePatterns;
        private IMessageTransformer _transformer;
        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            _phonePatterns = ReadPhonePatternsFromConfig().ToArray();
            _transformer = new SimpleMessageTransformer(_phonePatterns);
            _activeExplorer = Application.ActiveExplorer();
            _activeExplorer.SelectionChange += ActiveExplorerSelectionChange;
        }

        private void ActiveExplorerSelectionChange()
        {
            if (_activeExplorer.Selection.Count != 1) return;
            var mailItem = _activeExplorer.Selection[1] as MailItem;
            if (mailItem == null) return;
            TransformMessage(mailItem);
            mailItem.Save();
        }

        private void TransformMessage(MailItem mailItem)
        {
            if (_phonePatterns.Length == 0 || Transformed(mailItem)) return;// Не проводим трансформацию если отсутствую патерны или уже прошло трансформацию
            var message = mailItem.Body;
            var transformedMessage = _transformer.Transform(message);
            mailItem.HTMLBody = transformedMessage;
            SetTransformed(mailItem);
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            _activeExplorer.SelectionChange -= ActiveExplorerSelectionChange;
            _activeExplorer = null;
        }

        static bool Transformed(MailItem mailItem)
        {

            var prop = mailItem.UserProperties.Find(BeenTransformUserPropertyName);
            return prop != null && object.Equals(prop.Value, BeenTransformedValue);
        }

        static void SetTransformed(MailItem mailItem)
        {
            var prop = mailItem.UserProperties.Add(BeenTransformUserPropertyName, OlUserPropertyType.olInteger);
            prop.Value = BeenTransformedValue;
        }

        IEnumerable<Regex> ReadPhonePatternsFromConfig()
        {
            var defaultPatterns=
                 (new[] { "####", "##-##", "+# (###) ###-##-##" }).Select(RegexFromPatternBuilder.Build).ToArray();


            var configPath = GetConfigFilePath();
            if (configPath == null || !File.Exists(configPath)) return defaultPatterns;
            var config = OutlookLyncAddinConfig.FromXml(configPath);
            return config.Patterns.Select(FromPhonePatternElement).ToArray();
        }

        private static string GetConfigFilePath()
        {
            var registryKey =
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Office\Outlook\Addins\I-Teco.OutlookLyncAddin");
            Debug.Assert(registryKey != null, "registryKey != null");
            var manifestPath = Convert.ToString(registryKey.GetValue("Manifest", ""));
            if (String.IsNullOrEmpty(manifestPath)) return null;
            var addinDirPath = Path.GetDirectoryName(manifestPath);
            Debug.Assert(addinDirPath != null, "addinDirPath != null");
            var configPath = Path.Combine(addinDirPath, "addin.config.xml");
            return configPath;
        }

        static Regex FromPhonePatternElement(PhonePatternConfig element)
        {
            return element.IsRegex ? new Regex(element.Value) : RegexFromPatternBuilder.Build(element.Value);
        }

        #region VSTO generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Startup += ThisAddIn_Startup;
            Shutdown += ThisAddIn_Shutdown;
        }

        #endregion
    }
}