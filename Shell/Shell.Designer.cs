﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Daikoukai.Shell {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Shell : global::System.Configuration.ApplicationSettingsBase {
        
        private static Shell defaultInstance = ((Shell)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Shell())));
        
        public static Shell Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00x61CxJ4eA7TxqGHvdXx35U0294ZwSe")]
        public string Key {
            get {
                return ((string)(this["Key"]));
            }
            set {
                this["Key"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00x61CxJ4eA7TxqGHvdXx35U0294ZwSe")]
        public string IV {
            get {
                return ((string)(this["IV"]));
            }
            set {
                this["IV"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("256")]
        public int BlockSize {
            get {
                return ((int)(this["BlockSize"]));
            }
            set {
                this["BlockSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("256")]
        public int KeySize {
            get {
                return ((int)(this["KeySize"]));
            }
            set {
                this["KeySize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Zeros")]
        public global::System.Security.Cryptography.PaddingMode Padding {
            get {
                return ((global::System.Security.Cryptography.PaddingMode)(this["Padding"]));
            }
            set {
                this["Padding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CBC")]
        public global::System.Security.Cryptography.CipherMode Mode {
            get {
                return ((global::System.Security.Cryptography.CipherMode)(this["Mode"]));
            }
            set {
                this["Mode"] = value;
            }
        }
    }
}
