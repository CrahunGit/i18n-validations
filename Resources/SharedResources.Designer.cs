﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocalizationDemo.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SharedResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SharedResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LocalizationDemo.Resources.SharedResources", typeof(SharedResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; y &apos;{1}&apos; no coinciden.
        /// </summary>
        public static string Compare {
            get {
                return ResourceManager.GetString("Compare", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} no contiene un número válido de tarjeta de crédito..
        /// </summary>
        public static string CreditCard {
            get {
                return ResourceManager.GetString("CreditCard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} no es válido..
        /// </summary>
        public static string CustomValidation {
            get {
                return ResourceManager.GetString("CustomValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} no es una dirección válida de correo electrónico..
        /// </summary>
        public static string EmailAddress {
            get {
                return ResourceManager.GetString("EmailAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} sólo acepta archivos con las siguientes extensiones: {1}..
        /// </summary>
        public static string FileExtensions {
            get {
                return ResourceManager.GetString("FileExtensions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} debe tener una longitud máxima de &apos;{1}&apos;..
        /// </summary>
        public static string MaxLength {
            get {
                return ResourceManager.GetString("MaxLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} debe tener una longitud mínima de &apos;{1}&apos;..
        /// </summary>
        public static string MinLength {
            get {
                return ResourceManager.GetString("MinLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} no es un número de teléfono válido..
        /// </summary>
        public static string Phone {
            get {
                return ResourceManager.GetString("Phone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} debe estar entre {1} y {2}..
        /// </summary>
        public static string Range {
            get {
                return ResourceManager.GetString("Range", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} debe cumplir la expresión regular &apos;{1}&apos;..
        /// </summary>
        public static string RegularExpression {
            get {
                return ResourceManager.GetString("RegularExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} es obligatorio..
        /// </summary>
        public static string Required {
            get {
                return ResourceManager.GetString("Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} debe tener una longitud máxima de {1}..
        /// </summary>
        public static string StringLength {
            get {
                return ResourceManager.GetString("StringLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} debe tener entre {2} y {1} caracteres..
        /// </summary>
        public static string StringLengthIncludingMinimum {
            get {
                return ResourceManager.GetString("StringLengthIncludingMinimum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} no es una URL http, https, o ftp válida..
        /// </summary>
        public static string Url {
            get {
                return ResourceManager.GetString("Url", resourceCulture);
            }
        }
    }
}
