﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desktop.Analyzers {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DesktopAnalyzersResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DesktopAnalyzersResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Desktop.Analyzers.DesktopAnalyzersResources", typeof(DesktopAnalyzersResources).GetTypeInfo().Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do Not Catch Corrupted State Exceptions.
        /// </summary>
        internal static string DoNotCatchCorruptedStateExceptions {
            get {
                return ResourceManager.GetString("DoNotCatchCorruptedStateExceptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not author general catch handlers in code that receives corrupted state exceptions. Code that receives and intends to handle corrupted state exceptions should author distinct handlers for each exception type..
        /// </summary>
        internal static string DoNotCatchCorruptedStateExceptionsDescription {
            get {
                return ResourceManager.GetString("DoNotCatchCorruptedStateExceptionsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What: {0} is catching corrupted state exception.
        ///
        ///Why: This could mask errors (such as access violations), resulting in inconsistent state of execution or making it easier for attackers to compromise system.
        ///
        ///How: Modify {0} to catch and handle a more specific set of exception type(s) than {1} or re-throw the exception.
        /// </summary>
        internal static string DoNotCatchCorruptedStateExceptionsMessage {
            get {
                return ResourceManager.GetString("DoNotCatchCorruptedStateExceptionsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do Not Use Broken Cryptographic Algorithms.
        /// </summary>
        internal static string DoNotUseBrokenCryptographicAlgorithms {
            get {
                return ResourceManager.GetString("DoNotUseBrokenCryptographicAlgorithms", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An attack making it computationally feasible to break this algorithm exists. This allows attackers to break the cryptographic guarantees it is designed to provide. Depending on the type and application of this cryptographic algorithm, this may allow attackers to read enciphered messages, tamper with enciphered  messages, forge digital signatures, tamper with hashed content, or otherwise compromise any cryptosystem based on this algorithm. Replace encryption uses with the AES algorithm (AES-256, AES-192 and  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DoNotUseBrokenCryptographicAlgorithmsDescription {
            get {
                return ResourceManager.GetString("DoNotUseBrokenCryptographicAlgorithmsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} uses a broken cryptographic algorithm {1}.
        /// </summary>
        internal static string DoNotUseBrokenCryptographicAlgorithmsMessage {
            get {
                return ResourceManager.GetString("DoNotUseBrokenCryptographicAlgorithmsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do Not Use Weak Cryptographic Algorithms.
        /// </summary>
        internal static string DoNotUseWeakCryptographicAlgorithms {
            get {
                return ResourceManager.GetString("DoNotUseWeakCryptographicAlgorithms", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cryptographic algorithms degrade over time as attacks become for advances to attacker get access to more computation. Depending on the type and application of this cryptographic algorithm, further degradation of the cryptographic strength of it may allow attackers to read enciphered messages, tamper with enciphered  messages, forge digital signatures, tamper with hashed content, or otherwise compromise any cryptosystem based on this algorithm. 
        /// 
        ///HOW: Replace encryption uses with the AES algorithm (AES-25 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DoNotUseWeakCryptographicAlgorithmsDescription {
            get {
                return ResourceManager.GetString("DoNotUseWeakCryptographicAlgorithmsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} uses an weak cryptographic algorithm {1}.
        /// </summary>
        internal static string DoNotUseWeakCryptographicAlgorithmsMessage {
            get {
                return ResourceManager.GetString("DoNotUseWeakCryptographicAlgorithmsMessage", resourceCulture);
            }
        }
    }
}
